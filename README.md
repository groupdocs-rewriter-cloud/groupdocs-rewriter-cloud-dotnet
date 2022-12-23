# .NET SDK for Paraphrasing Cloud Documents

![](https://img.shields.io/badge/api-v1.0-lightgrey) ![Nuget](https://img.shields.io/nuget/v/GroupDocs.Rewriter-Cloud) ![Nuget](https://img.shields.io/nuget/dt/GroupDocs.Rewriter-Cloud) [![GitHub license](https://img.shields.io/github/license/groupdocs-rewriter-cloud/groupdocs-rewriter-cloud-dotnet)](https://github.com/groupdocs-rewriter-cloud/groupdocs-rewriter-cloud-dotnet/blob/master/LICENSE)

[Product Page](https://products.groupdocs.cloud/rewriter/) | [Docs](https://docs.groupdocs.cloud/rewriter/) | [Demos](https://products.groupdocs.app/rewriter/family) | [Swagger UI](https://apireference.groupdocs.cloud/rewriter/) | [Examples](https://github.com/groupdocs-rewriter-cloud/groupdocs-rewriter-cloud-dotnet) | [Blog](https://blog.groupdocs.cloud/category/rewriter/) | [Search](https://search.groupdocs.cloud/) | [Free Support](https://forum.groupdocs.cloud/c/rewriter) | [Free Trial](https://purchase.groupdocs.cloud/trial)

GroupDocs.Rewriter Cloud SDK for .NET is a simple C#/.NET SDK that enables your cloud Apps to perform paraphrasing of Microsoft Word®, OpenOffice, Markdown, HTML and Adobe Acrobat® PDF documents as well as paraphrase plain text by adding just a few lines of code.

In other words, it's a SDK for document and plain text rewriting in our Cloud, that supports paraphrasing of .doc, .docx, .docm, .pdf, .rtf, .odt, .md, .html, .txt files. Just pass a specific file or text to the GroupDocs.Rewriter Cloud API, and it will rewrite and save rewrited file in our Cloud or will return paraphrased text.

It is easy to get started with GroupDocs.Rewriter Cloud and there is nothing to install. Create an account at GroupDocs Cloud and get your application information, then you are ready to use SDKs.

## Cloud Document Paraphraser Features

- Paraphrasing (rewriting) of documents
- Paraphrasing (rewriting) of plain text
- Return paraphrased (rewrited) text in response
- Save paraphrased (rewrited) file in cloud
- Ability to manage your files and folders in our Cloud
- No need to install any 3rd party software

## Supported Document Formats

You can specify format of document to rewrite putting in the request’s body:

- **Microsoft Word®:** DOC, DOCX, DOCM
- **Adobe®:** PDF
- **Markdown:** MD
- **HTML:** HTML
- **Other:** RTF, ODT, TXT

Additionally, user could obtain rewrited file in any other format available for conversion. Just specify output format of paraphrased document by putting file extension in the request’s body:

- **doc, docx** — docx, rtf, html, odt, txt, md, pdf, tiff, svg, xps
- **pdf** — docx, pptx, html, svg, xps
- **html** — md, pdf, docx, tiff, xps

Please visit [Supported Formats](https://docs.groupdocs.cloud/rewriter/supported-formats/) for details.

## Supported Languages

- **en** — to paraphrase English text or document
- **ru** — to paraphrase Russian text or document
- **uk** - to paraphrase Ukrainian text or document
- **ar** - to paraphrase Arabic text or document

## JSON Request Details

You can put the following information in the requests body to rewrite a document:

- **format** — format of file for rerwriting (e.g. docx)
- **outformat** — format of rewrited file (e.g. pdf)
- **language** — language of document (e.g. en)
- **name** — name of file to rewrite (e.g. test.docx)
- **folder** — folder of file to rewrite (e.g. rewrite)
- **savepath** — folder for rewrited file (e.g. rewrited)
- **savefile** — name of rewrited file (e.g. rewrited.docx)
- **storage** — name of storage
- **diversity** - diversity of paraphrasing, "medium" or "high", default is "off"

To paraphrase plain text the following information should be put in the requests body:

- **language** — language of text (e.g. en)
- **text** — text to paraphrase (e.g. hello world)
- **diversity** - diversity of paraphrasing, "medium" or "high", default is "off"
- **suggestions** — to receive several suggested variants of paraphrasing (from 1 to 3)

## How to use the SDK?

Our API is completely independent of your operating system, database system, or development language. You can use any language and platform that supports HTTP to interact with our API. However, manually writing client code can be difficult, error-prone, and time-consuming. Therefore, we provide and support [SDKs](https://github.com/groupdocs-rewriter-cloud) in many development languages to make it easier for your Cloud Apps to integrate with us.


## Quickstart

#### 1. Get Started

It is easy to get started with GroupDocs.Rewriter Cloud. Simply, create an account at [GroupDocs Cloud](https://dashboard.groupdocs.cloud/#/apps) and get your application information, then you are ready to use the [SDKs](https://github.com/groupdocs-rewriter-cloud).

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
string diversity = "medium";
int suggestions = 2;

RewriteTextRequest request = api.CreateTextRequest(language, text);
TextResponse response = api.RunTranslationTextTask(request);
```

## GroupDocs.Rewriter Cloud SDKs in Popular Languages

| .NET | Python |
|---|---|
| [GitHub](https://github.com/groupdocs-rewriter-cloud/groupdocs-rewriter-cloud-dotnet) | [GitHub](https://github.com/groupdocs-rewriter-cloud/groupdocs-rewriter-cloud-dotnet) |
| [NuGet](https://www.nuget.org/packages/GroupDocs.Rewriter-Cloud/) | [PyPi](https://pypi.org/project/groupdocs-rewriter-cloud/) |

[Product Page](https://products.groupdocs.cloud/rewriter/dotnet/) | [Docs](https://docs.groupdocs.cloud/rewriter/) | [Demos](https://products.groupdocs.app/rewriter/family) | [Swagger UI](https://apireference.groupdocs.cloud/rewriter/) | [Examples](https://github.com/groupdocs-rewriter-cloud/groupdocs-rewriter-cloud-dotnet) | [Blog](https://blog.groupdocs.cloud/category/rewriter/) | [Search](https://search.groupdocs.cloud/) | [Free Support](https://forum.groupdocs.cloud/c/rewriter) | [Free Trial](https://purchase.groupdocs.cloud/trial)