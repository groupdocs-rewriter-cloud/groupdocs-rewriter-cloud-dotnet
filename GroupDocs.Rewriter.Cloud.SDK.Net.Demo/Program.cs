using System;
using System.Collections.Generic;
using System.IO;
using GroupDocs.Rewriter.Cloud.SDK.NET;
using GroupDocs.Rewriter.Cloud.SDK.NET.Model;
using GroupDocs.Rewriter.Cloud.SDK.NET.Model.Requests;

namespace GroupDocs.Rewriter.Cloud.SDK.Net.Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            // add your ClientId and ClientSecret
            Configuration conf = new Configuration();
            conf.ClientId = "rewriter.cloud";
            conf.ClientSecret = "f692c7d4b2817c3112c126519b993577";


            if (string.IsNullOrEmpty(conf.ClientId) || string.IsNullOrEmpty(conf.ClientSecret))
                throw new Exception("Please, get and set your ClientId and ClientSecret. https://dashboard.groupdocs.cloud/#/");


            FileResponse hcResponse = new FileResponse();
            TextResponse textResponse = new TextResponse();
            NET.Model.FileInfo fileInfo = new NET.Model.FileInfo();
            TextInfo textInfo = new TextInfo();
            string[] languages;

            //Console.WriteLine("Example #1:\nDocument rewriting of file in GroupDocs Storage");
            //RewriteDocument(conf);

            Console.WriteLine("Example #2:\nText rewriting");
            RewriteText(conf);

            //Console.WriteLine("Example #3:\nHealth check");
            //hcResponse = HealthCheck(conf);
            //Console.WriteLine(hcResponse);

            //Console.WriteLine("Example #4:\nGet structure of document request");
            //fileInfo = GetDocRequest(conf);
            //Console.WriteLine(fileInfo.ToString());

            //Console.WriteLine("Example #5:\nGet structure of text request");
            //textInfo = GetTextRequest(conf);
            //Console.WriteLine(textInfo.ToString());

            //Console.WriteLine("Example #6:\nGet languages");
            //languages = GetLanguages(conf);
            //foreach (var language in languages)
            //{
            //    Console.WriteLine(language);
            //}
        }

        static void RewriteDocument(Configuration conf)
        {
            // request parameters for rewriting
            string name = "test.docx";
            string folder = "";
            string language = "en";
            string format = "docx";
            string outformat = "docx";
            string storage = ""; //add storage name of your app
            string saveFile = "rewrited.docx";
            string savePath = "";
            string origin = ".NET";
            string diversity = "medium";
            bool details = false;

            // local paths to upload and download files
            string uploadPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + "/" + name;
            string downloadPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.Parent.FullName + "/" + saveFile;

            RewriterApi api = new RewriterApi(conf);
            FileApi fileApi = new FileApi(conf);

            
            Stream stream = File.Open(uploadPath, FileMode.Open);

            UploadFileRequest uploadRequest= new UploadFileRequest { File = stream, path = name, storageName = storage };
            FilesUploadResult uploadResult = fileApi.UploadFile(uploadRequest);
            Console.WriteLine("Files uploaded: " + uploadResult.Uploaded.Count);
                        
            RewriteDocumentRequest request = api.CreateDocumentRequest(name, folder, language, format, outformat, storage, saveFile, savePath, diversity, details, origin);
            FileResponse response = api.RunRewriteTask(request);
            Console.WriteLine(response.Message);

            DownloadFileRequest downloadRequest = new DownloadFileRequest { storageName = storage, path = saveFile };
            Stream result = fileApi.DownloadFile(downloadRequest);
            Console.WriteLine("Translated file downloaded");
            
            using (FileStream file = new FileStream(downloadPath, FileMode.Create, FileAccess.Write))
            {
                result.CopyTo(file);
            }
            Console.WriteLine("Translated file saved");
        }

        static void RewriteText(Configuration conf)
        {
            // add text for rewriting and language
            string language = "en";
            string text = "The Abel Prize is awarded annually by the King of Norway to one or more outstanding mathematicians. It is named after Norwegian mathematician Niels Henrik Abel (1802–1829) and directly modeled after the Nobel Prizes. It comes with a monetary award of 7.5 million Norwegian kroner (increased from 6 million in 2019).";
            string[] levels = { "off", "medium","high" };
            Random r = new Random();
            int suggestions = 1; //r.Next(1, 3);
            bool tokenize = true;
            RewriterApi api = new RewriterApi(conf);
            foreach (string level in levels)
            {
                RewriteTextRequest request = api.CreateTextRequest(language, text, level, suggestions, tokenize);
                TextResponse response = api.RunRewriteTextTask(request);
                Console.WriteLine(response.Result);
                foreach (string target in response.TargetList)
                {
                    Console.WriteLine(target);
                }
            }

            //if (suggestions == 1)
            //{
            //    Console.WriteLine(response.Result);
            //}
            //else
            //{
            //    foreach (string result in response.Results)
            //    {
            //        Console.WriteLine(result);
            //    }
            //}
        }

        static NET.Model.FileInfo GetDocRequest(Configuration conf)
        {
            RewriterApi api = new RewriterApi(conf);
            NET.Model.FileInfo info = api.GetDocumentRequestStructure();
            return info;
        }

        static TextInfo GetTextRequest(Configuration conf)
        {
            RewriterApi api = new RewriterApi(conf);
            TextInfo info = api.GetTextRequestStructure();
            return info;
        }

        static FileResponse HealthCheck(Configuration conf)
        {
            RewriterApi api = new RewriterApi(conf);
            FileResponse response = api.RunHealthCheck();
            return response;
        }

        static string[] GetLanguages(Configuration conf)
        {
            RewriterApi api = new RewriterApi(conf);
            string[] response = api.GetLanguages();
            return response;
        }
    }
}
