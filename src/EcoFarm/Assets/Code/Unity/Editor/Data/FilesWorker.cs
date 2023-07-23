using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Code.Unity.Editor.Data
{
	public static class FilesWorker
	{
		private const string DirectoryPath = "DataModel/Dll";

		public static void CopyDlls(string pathToDlls)
		{
			CopyFilesWithExtension("*.dll", from: pathToDlls);
			Debug.Log("Dlls copied");
		}

		private static void CopyFilesWithExtension(string extension, string from)
			=> CopyFilesToProject(Directory.GetFiles(from, extension, SearchOption.AllDirectories));

		private static void CopyFilesToProject(IEnumerable<string> files) => files.ForEach(Copy, @if: NameNotNull);

		private static bool NameNotNull(string file) => Path.GetFileName(file) != null;

		private static void Copy(string file) => File.Copy(file, GetDestinationFor(file), overwrite: true);

		private static string GetDestinationFor(string file)
			=> Path.Combine(Application.dataPath, DirectoryPath, Path.GetFileName(file));
	}
}