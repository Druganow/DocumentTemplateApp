using System.Collections.Generic;

namespace DocumentTemplateApp
{
    abstract class Template
    {
        public abstract List<string> GetFieldsTemplate();
        public abstract void ReplaceText(Dictionary<string, string> ob);
        public abstract void SaveFile(string path);
        public abstract string GetText();
    }
}
