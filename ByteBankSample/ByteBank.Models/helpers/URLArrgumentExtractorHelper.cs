using System;
using System.Collections;
using System.Collections.Generic;


namespace ByteBank.helpers
{
    public static class  URLArrgumentExtractorHelper
    {
        public static List<UrlArgument> GetParameters(String url)
        {
            String _url = url.Remove(0, url.IndexOf('?') + 1);
            List<UrlArgument> arguments = new List<UrlArgument>();

            Int32 _argumentsCount = _url.Length - _url.Replace("=", "").Length;
            for (Int32 i = 0; i < _argumentsCount; i++)
            {                                
                Int32 _equals = _url.IndexOf('=');
                Int32 _end = _url.IndexOf('&');
                String _name;
                String _value;

                if (_end <= 0)
                {
                    _end = _url.Substring(_url.IndexOf("=")).Length - 1;
                    _name = _url.Substring(0, _equals);
                    _value = _url.Substring(_equals + 1, _end);
                }
                else {
                    _name = _url.Substring(0, _equals);
                    _value = _url.Substring(_equals + 1, _end - _equals - 1);
                }
               
                UrlArgument argument = new UrlArgument(_name, _value);

                arguments.Add(argument);

                if (_url.IndexOf('&') > 0)
                {
                    _url = _url.Remove(0, _url.IndexOf('&')+1);
                }
                
            }
            return arguments;
        }

        public static String GetExplainedUrlArguments(String url)
        {
            String _explainedUrlArguments =
                "______________________________________________________________________\n" +
                "| The arguments found in the string: " + url + "\n" +
                "|______________________________________________________________________";

            List<UrlArgument> argumentsList = GetParameters(url);
            
            for (Int32 i = 0; i < argumentsList.Count; i++)
            {
                _explainedUrlArguments += 
                    "\n|  "+argumentsList[i].Name + " = " + argumentsList[i].Value +
                    "\n|______________________________________________________________________";
            }

            return _explainedUrlArguments;
        }
    }
}
