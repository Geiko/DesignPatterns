using _3_Patterns._3._Leaf;
using _3_Patterns.Composite;
using _3_Patterns.MenuComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Component rootMenu = new Menu("root");

            //----------------------------------------------
            Component undo = new Utility("Undo");
            Component redo = new Utility("Redo");
            rootMenu.Add(undo);
            rootMenu.Add(redo);
            
            //----------------------------------------------
            Component file = new Menu("File");

            Component newFile = new Utility("New");
            Component openFile = new Utility("Open...");

            Component saveFile = new Menu("SaveFile");
            Component save = new Utility("Save");
            Component saveAs = new Utility("SaveAs...");

            saveFile.Add(save);
            saveFile.Add(saveAs);
            file.Add(newFile);
            file.Add(openFile);
            file.Add(saveFile);
            rootMenu.Add(file);
            
            //----------------------------------------------
            Component edit = new Menu("Edit");

            Component cut = new Utility("Cut");
            Component copy = new Utility("Copy");
            Component paste = new Utility("Paste");
            Component selectAll = new Utility("SelectAll");

            edit.Add(cut);
            edit.Add(copy);
            edit.Add(paste);
            edit.Add(selectAll);
            rootMenu.Add(edit);

            //----------------------------------------------
            rootMenu.Print();
            Console.ReadKey();
        }
    }
}
