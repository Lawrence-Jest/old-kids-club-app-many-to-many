using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KidsClubApp.Client.Static
{
    public class Endpoints
    {
        public static string Prefix = "api";

        public static string AddressesEndpoint = $"{Prefix}/addresses/";
        public static string ChildrenEndpoint = $"{Prefix}/children/";
        public static string ParentsEndpoint = $"{Prefix}/parents";
        public static string SignInSheetEntriesEndpoint = $"{Prefix}/signinsheetentries/";
    }
}
