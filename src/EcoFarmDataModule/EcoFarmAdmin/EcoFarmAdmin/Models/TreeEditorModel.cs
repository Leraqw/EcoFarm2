using System;
using System.Windows;
using EcoFarmAdmin.Domain;

namespace EcoFarmAdmin.ViewModels;

public class TreeEditorModel
{
	public static void AddTree() => DataBaseConnection.CurrentContext.Trees.Add(new Tree());

	public static void DeleteTree(Tree tree)
	{
		try
		{
			DataBaseConnection.CurrentContext.Trees.Remove(tree);
		}
		catch (Exception e)
		{
			MessageBox.Show(e.Message);
		}
	}
}