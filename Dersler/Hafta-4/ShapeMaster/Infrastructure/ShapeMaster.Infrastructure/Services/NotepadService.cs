using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShapeMaster.Domain.Common;
namespace ShapeMaster.Infrastructure.Services
{
    internal class NotepadService
    {

        public void SaveToNotepad(Shape shape)
        {
            bool isExist = DirectoryService.isFileExist(DirectoryService.DatabasePath);
            if(!isExist)
                DirectoryService.CreateFolder(DirectoryService.DatabasePath);

            File.AppendAllText(DirectoryService.DatabasePath+$"{shape.Type}.txt", shape.GetInfo();
        }

        public string GetOnNotepad(Shape shape)
        {
            return DirectoryService.ReadFile(DirectoryService.DatabasePath + $"{shape.Type}");
        }
    }
}
