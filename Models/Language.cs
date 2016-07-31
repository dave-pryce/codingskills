using System.Collections.Generic;

namespace codingskills.Models
{
  public class Language
  {
    public string Name;

    public static void Create(string LanguageName)
    {
      var language = new Language();
      language.Name = LanguageName;
      GlobalVariables.Language.Add(language);
    }

    public static List<Language> GetAll()
    {
      return GlobalVariables.Language;
    }
  }
}
