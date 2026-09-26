// See https://aka.ms/new-console-template for more information

using System.Text;

var s = "(name)is(age)yearsold";
var knowledge = new List<IList<string>> {
    new List<string> { "name", "bob" },
    new List<string> { "age", "30" }
};


Console.WriteLine(Evaluate(s, knowledge));


static string Evaluate(string s, IList<IList<string>> knowledge) {
    // move knowledge into a dictionary
    var dict = new Dictionary<string, string>();
    foreach(var kv in knowledge)
    {
       if(kv.Count > 1)
       {
         dict.Add(kv[0], kv[1]);
       }
    }

    // process char at a time
    var output = new StringBuilder();
    for(var i = 0; i < s.Length; i++) 
    {
       if(s[i] == '(')
       {
          // read up to closing )
          var ep = s.IndexOf(')', i+1);
          if(ep > -1)
          {
            var key = s[(i+1) .. ep];
            i = ep;
            if(dict.ContainsKey (key))
            {
              output.Append(dict[key]);
            }
            else
            {
              output.Append("?");
            }
          }
       }
       else
       {
         output.Append(s[i]);
       }
    }

    return output.ToString(); 
}
