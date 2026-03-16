using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace LifeLog.Core.Utils;

/// <summary>
/// Pdf -related utility functions, such as merging multiple PDF files into a single document. 
/// </summary>
public static class PdfUtil
{
  
    /// <summary>
    /// Merges all PDF files in the specified directory into a single PDF document and saves the result to the
    /// specified output path.
    /// </summary>
    /// <remarks>Ensure that the outputPath is valid and writable. The method merges all PDF files
    /// found in the specified directory, ordering them by file name. The resulting PDF will contain all pages from
    /// the input files in order.</remarks>
    /// <param name="directoryPath">The path to the directory containing the PDF files to merge. The directory must exist.</param>
    /// <param name="outputPath">The file path where the merged PDF document will be saved. If a file already exists at this path, it will be
    /// overwritten.</param>
    /// <param name="includeSubdirectories">true to include PDF files from all subdirectories; false to search only the top-level directory. The default
    /// is false.</param>
    /// <exception cref="DirectoryNotFoundException">Thrown if the directory specified by directoryPath does not exist.</exception>
    /// <exception cref="FileNotFoundException">Thrown if no PDF files are found in the specified directory (and subdirectories, if includeSubdirectories is
    /// true).</exception>
    public static void MergePdfs(List<string> pdfFiles, string outputPath)
    {
        if (pdfFiles.Count == 0)
            throw new FileNotFoundException("No pdf was found.");

        using PdfDocument outputDocument = new();
        foreach (string file in pdfFiles)
        {
            using PdfDocument inputDocument = PdfReader.Open(file, PdfDocumentOpenMode.Import);
            for (int i = 0; i < inputDocument.PageCount; i++)
                outputDocument.AddPage(inputDocument.Pages[i]);
        }

        outputDocument.Save(outputPath);
    }
}
