using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces3
{
    public interface forlanguage
    {
        public void Language();
    }
    public class EnglishLanguages: forlanguage
    {
        public void Language()
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add("C++");
            arrayList.Add("c#");
            arrayList.Add("Python");
            arrayList.Add("JavaScript");

            foreach(string str in arrayList)
            {
                Console.WriteLine(str);
            }
        }
    }

    public class HindiLanguages : forlanguage
    {
        public void Language()
        {
            ArrayList arrayList = new ArrayList();

            arrayList.Add("C++");
            arrayList.Add("c#");
            arrayList.Add("Python");
            arrayList.Add("JavaScript");

            foreach (string str in arrayList)
            {
                Console.WriteLine(str);
            }
        }
    }

    interface forSubjects
    {
        public void Subject();
    }
    public class Subjects: forSubjects
    {
        public void Subject( string  languageType)
        {
            //forSubjects sub = new EnglishLanguages();
            forlanguage language = null;
            switch (languageType)
            {
                case "Hindi":
                    language= new HindiLanguages();
                    break;
                default:
                    language = new EnglishLanguages();
                    break;
            }
            Read(language);
            ArrayList arrayList = new ArrayList();

            arrayList.Add("C++");
            arrayList.Add("c#");
            arrayList.Add("Python");
            arrayList.Add("JavaScript");

            foreach (string str in arrayList)
            {
                Console.WriteLine(str);
            }
        }

        public void Read(forlanguage language)
        {

        }

        public void Subject()
        {
            throw new NotImplementedException();
        }
    }
    public class MultipleInheritance : forSubjects, forlanguage
    {
      //  languages lan = new languages();
        forSubjects sub = new Subjects();
        public void Language()
        {
            //lan.Language();
        }

        public void Subject()
        {
            sub.Subject();
        }
    }
}
