using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyDirectoryCreator.Model
{
    public class FolderScheme
    {
        public string FolderParent { get; set; }
        public List<FolderScheme> ChildFolders { get; set; } = new List<FolderScheme>();
    }
}
