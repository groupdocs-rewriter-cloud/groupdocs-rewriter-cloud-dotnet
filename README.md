# .NET SDK for Paraphrasing Cloud Documents

![](https://img.shields.io/badge/api-v1.0-lightgrey) ![Nuget](https://img.shields.io/nuget/v/GroupDocs.Rewriter-Cloud) ![Nuget](https://img.shields.io/nuget/dt/GroupDocs.Rewriter-Cloud) [![GitHub license](https://img.shields.io/github/license/groupdocs-translation-cloud/groupdocs-translation-cloud-dotnet)](https://github.com/groupdocs-translation-cloud/groupdocs-translation-cloud-dotnet/blob/master/LICENSE)

[Product Page](https://products.groupdocs.cloud/rewriter/) | [Docs](https://docs.groupdocs.cloud/rewriter/) | [Demos](https://products.groupdocs.app/rewriter/family) | [Swagger UI](https://apireference.groupdocs.cloud/rewriter/) | [Examples](https://github.com/groupdocs-rewriter-cloud/groupdocs-rewriter-cloud-dotnet) | [Blog](https://blog.groupdocs.cloud/category/rewriter/) | [Search](https://search.groupdocs.cloud/) | [Free Support](https://forum.groupdocs.cloud/c/rewriter) | [Free Trial](https://purchase.groupdocs.cloud/trial)

[GroupDocs.Rewriter Cloud](https://products.groupdocs.cloud/rewriter/) is Cloud API to paraphrase Microsoft Word and PDF files as well as plain text.

For convenience of our .NET customers, we introduce a simple SDK that assists to add paraphrasing of Microsoft Word documents, PDF documents and plain text to your app with merely a few lines of code.

In detail, it's a set of SDKs for document and plain text rewriting in our Cloud. It supports paraphrasing of .doc, .docx, .docm, .pdf files. Just pass a specific file or text to the GroupDocs.Rewriter Cloud API, and it will rewrite and save rewrited file in our Cloud or will return paraphrased text.

It is easy to get started with GroupDocs.Rewriter Cloud and there is nothing to install. Create an account at GroupDocs Cloud and get your application information, then you are ready to use SDKs.

## Cloud Document Rewriting Features

- Translation of Microsoft Word® documents
- Translation of PDF files
- Translation of plain text
- API that allows you to manage your files and folders in our Cloud

## Supported Rewrriting Formats

You can specify format of document to rewrite putting in the request’s body:

- **extension of word file (docx / docm / doc)** — to translate **Microsoft Word® document**
- **extension of PDF file (pdf)** — to translate **Adobe PDF document**

Additionally, user could obtain rewrited file in any other format available for conversion. Just specify output format of paraphrased document by putting file extension in the request’s body:

- **doc, docx** — docx, rtf, html, odt, txt, md, pdf, tiff, svg, xps
- **pdf** — docx, pptx, html, svg, xps

Please visit [Supported Formats](https://docs.groupdocs.cloud/rewriter/supported-formats/) for details.

## Supported Languages

- **en** — to paraphrase English text or document

## JSON Request Details

You can put the following information in the requests body to rewrite a document:

- **format** — format of file for rerwriting (e.g. docx)
- **outformat** — format of rewrited file (e.g. pdf)
- **language** — language of document (e.g. en)
- **name** — name of file to rewrite (e.g. test.docx)
- **folder** — folder of file to rewrite (e.g. translate)
- **savepath** — folder for rewrited file (e.g. rewrited)
- **savefile** — name of rewrited file (e.g. rewrited.docx)
- **storage** — name of storage

To paraphrase plain text the following information should be put in the requests body:

- **language** — language of text (e.g. en)
- **text** — text to paraphrase (e.g. hello world)

## How to use the SDK?

Our API is completely independent of your operating system, database system, or development language. You can use any language and platform that supports HTTP to interact with our API. However, manually writing client code can be difficult, error-prone, and time-consuming. Therefore, we provide and support [SDKs](https://github.com/groupdocs-translation-cloud) in many development languages to make it easier for your Cloud Apps to integrate with us.


## Quickstart

#### 1. Get API keys if you haven't

Make a personal account on [GroupDocs Cloud Dashboard](https://dashboard.groupdocs.cloud/#/) and click _Get Keys_. These keys are useful for all GroupDocs Cloud products. If you have any trouble, look at this [detailed manual](https://docs.groupdocs.cloud/total/creating-and-managing-application/). Once your keys are received, please follow this [article](https://docs.groupdocs.cloud/rewriter/quickstart/) to try GroupDocs.Rewriter Cloud or familiarize with [Developer guide](https://docs.groupdocs.cloud/rewriter/developer-guide/) for further details.

#### 2. Run Demo
  * Checkout the SDK
  * Open .NET core demo project
  * Set Your ClientId & ClientSecret
  * Run


## Rewrite plain text

```csharp
// Get Client Id and Client Secret from https://dashboard.groupdocs.cloud
string MyClientId = "";
string MyClientSecret = "";

// Create instance of the API
var configuration = new Configuration(MyClientId, MyClientSecret);
RewriterApi api = new RewriterApi(configuration);

string language = "en";
string text = "Welcome to Paris";

RewriteTextRequest request = api.CreateTextRequest(language, text);
TextResponse response = api.RunTranslationTextTask(request);
```

## GroupDocs.Translation Cloud SDKs in Popular Languages

| .NET |
|---|
| [GitHub](https://github.com/groupdocs-translation-cloud/groupdocs-translation-cloud-dotnet) |
| [NuGet](https://www.nuget.org/packages/GroupDocs.translation-Cloud/) | 

[Product Page](https://products.groupdocs.cloud/rewriter/dotnet/) | [Docs](https://docs.groupdocs.cloud/rewriter/) | [Demos](https://products.groupdocs.app/rewriter/family) | [Swagger UI](https://apireference.groupdocs.cloud/rewriter/) | [Examples](https://github.com/groupdocs-rewriter-cloud/groupdocs-rewriter-cloud-dotnet) | [Blog](https://blog.groupdocs.cloud/category/rewriter/) | [Search](https://search.groupdocs.cloud/) | [Free Support](https://forum.groupdocs.cloud/c/rewriter) | [Free Trial](https://purchase.groupdocs.cloud/trial)