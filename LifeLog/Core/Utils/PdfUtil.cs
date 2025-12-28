using PdfSharp.Pdf;
using PdfSharp.Pdf.IO;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Core.Utils
{
	/// <summary>
	/// PDF util
	/// </summary>
	public static class PdfUtil
	{
		/// <summary>
		/// Faz merge de todos os PDFs encontrados na diretoria indicada.
		/// </summary>
		/// <param name="directoryPath">Diretoria onde procurar os ficheiros PDF.</param>
		/// <param name="outputPath">Caminho do ficheiro PDF de saída.</param>
		/// <param name="includeSubdirectories">Se deve procurar também em subdiretórios.</param>
		public static void MergeAllPdfsInDirectory(string directoryPath, string outputPath, bool includeSubdirectories = false)
		{
			if (!Directory.Exists(directoryPath))
				throw new DirectoryNotFoundException($"Directory is not valid: {directoryPath}");

			SearchOption searchOption = includeSubdirectories ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

			List<string> pdfFiles = Directory
				.EnumerateFiles(directoryPath, "*.pdf", searchOption)
				.OrderBy(f => f)
				.ToList();

			if (!pdfFiles.Any())
				throw new FileNotFoundException("No pdf was found.");

			using (PdfDocument outputDocument = new PdfDocument())
			{
				foreach (string file in pdfFiles)
				{
					using (PdfDocument inputDocument = PdfReader.Open(file, PdfDocumentOpenMode.Import))
					{
						for (int i = 0; i < inputDocument.PageCount; i++)
						{
							outputDocument.AddPage(inputDocument.Pages[i]);
						}
					}
				}

				outputDocument.Save(outputPath);
			}
		}
	}
}
