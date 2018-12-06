using System.Collections.Generic;
using System.Linq;

namespace Advent_of_Code
{
    public class Day02
    {
        public static readonly string[] puzzleInput = new string[] { "jplenqtlagxhivmwmscfukzodp", "jbrehqtlagxhivmeyscfuvzodp", "jbreaqtlagxzivmwysofukzodp", "jxrgnqtlagxhivmwyscfukwodp", "jbrenqtwagjhivmwysxfukzodp", "jbrenqplagxhivmwyscfuazoip", "jbrenqtlagxhivzwyscfldzodp", "jbrefqtlagxhizmwyfcfukzodp", "jbrenqtlagxhevmwfsafukzodp", "jbrunqtlagxrivmsyscfukzodp", "jbrenqtlaguhivmwyhlfukzodp", "jbrcnstsagxhivmwyscfukzodp", "jbrenqtlagozivmwyscbukzodp", "jbrenqwlagxhivswysrfukzodp", "jbrenstlagxhuvmiyscfukzodp", "jbranqtlhgxhivmwysnfukzodp", "jbrenqtvagxhinmxyscfukzodp", "jbrenqtlagdhivmwyscfukxody", "jbrenqtlagelavmwyscfukzodp", "jbrenqtlagxhtvmwyhcfukzbdp", "jbrenqwlagxhivmwyscfutzopp", "jbrenqtlavxhibmtyscfukzodp", "jbronqtlagxnivmwyscfuzzodp", "jbredqtlagxhppmwyscfukzodp", "jbrcnqtlogxhivmwysxfukzodp", "jbremqtlagehivswyscfukzodp", "jbrenqolagxhivmcyscfukzokp", "jbrehqtlacxhgvmwyscfukzodp", "fbrlnqtlagxhivmwyscbukzodp", "zbrfnqtlagxhivrwyscfukzodp", "jbregqtlagxnivmwyscfhkzodp", "jbrenqtllgxnivmwystfukzodp", "jurenqtlagxhivmwyscfulzoup", "jbrenitdagxhivmwyxcfukzodp", "jbrenqtlagxqivmwyscvuszodp", "jbqenqwlagxhivmwyscfckzodp", "jbrenqtlagxhivmwxscqupzodp", "jbrenqtlagxhivmwysciuqiodp", "jbrjnjtlagxhivmwyscfukzode", "jbrenqtlagxhuvmwqscfukzods", "jbrenqtlagxhuvmuyscfukzudp", "ibrenqtlagxhivmwyscfuktokp", "jbsenqtlagxhivcwyscfuksodp", "jbrfnntlagxhivmwnscfukzodp", "jzrenqulagxhivmwyscfukzodx", "jbrenqtqygxhivmwyscfukzwdp", "jbrenqtlagxfixmwyscfukzcdp", "jbrenqaoagxhivmwyshfukzodp", "jbrenqtlazxhivmworcfukzodp", "jbrenqtlagxhicowyscfukrodp", "jbrqnqtlagxhivzwyzcfukzodp", "jbrenqtlalxhuvxwyscfukzodp", "jbrenqtlqgxhhviwyscfukzodp", "jbrenqtuggxhivmoyscfukzodp", "jbrenqtlagxpivmwyscfukkodw", "zbrenqhlagxhivmwyscdukzodp", "jbrenutlagxxivmwyscfukzoqp", "obrenqtlagxhivmwxscfuszodp", "jbrenqtlagxhlvmwyscfuixodp", "rbrenqtlagdhixmwyscfukzodp", "jbrenqtlagxhivmwescfyszodp", "jbrfnqtlagxhivmwyscaukzhdp", "jbrenqtiagxhivmbyscfuxzodp", "cbrrnqtuagxhivmwyscfukzodp", "jbkenqtlagxhigmwysufukzodp", "jbjewqtlagxhivmwyscfuqzodp", "jbrznqtlagxvivmwyscfukzovp", "jbrenttlacxhivmwyscfhkzodp", "jblenqtlagxhivmwylcfukaodp", "jbrenqtlagxhivmqysiftkzodp", "jbrenqtlagwhikmwyscfukqodp", "jbrenqtlegxhivmwvsckukzodp", "jbrenqwzagxhiamwyscfukzodp", "jbrenqtlagxhivcwyscfgkzodc", "jbrenqtlagxxhvmwxscfukzodp", "jbrenqtlngxhivmwyscfukoowp", "jbreomtlagxhivmwpscfukzodp", "jfrenqtlagxhivmwyscnumzodp", "jbrenqtlagphipmwyscfukfodp", "jvrenqtlagxhivmwyscfmkzodw", "jbrenqtlaxxoiemwyscfukzodp", "jbrenqtlagxhivmwyscemkzpdp", "jbrenyjldgxhivmwyscfukzodp", "jbrenqtlagxhivfvyspfukzodp", "kbrenctlakxhivmwyscfukzodp", "jbrmhqtlagxhivmwyscfuizodp", "jbjenqtlagxlivmbyscfukzodp", "jbrenqtlaaxhivmmyshfukzodp", "jbronqtlagxhirmvyscfukzodp", "jbcrnqtlagxwivmwyscfukzodp", "jxrenszlagxhivmwyscfukzodp", "jbpenqtlagxhivmwyscfukkody", "jbrewqtlawxhivmwyscfukzhdp", "jbrenqylagxhivmwlxcfukzodp", "jbrenqtlagxxivtwywcfukzodp", "jbrenqtlagxhcvgayscfukzodp", "jbrenitlagxhivmwiscfukzohp", "jbrenutlagxhivmwyscbukvodp", "nbrenqtlagxhivmwysnfujzodp", "jbrenqtlagxhivmwyqcfupzoop", "jbrenqtrarxhijmwyscfukzodp", "jbrenqtlagxhivmwysdfukzovy", "jbrrnqtlagxhivmwyvcfukzocp", "jbrenqtlagxhivmwyscfuvzzhp", "jbhenitlagxhivmwysufukzodp", "jbrenqtlagxhivmwyscfuwzoqx", "kbrenqtlagxhivmwysqfdkzodp", "jbrenqtlagxhivmwyxmfukzodx", "jbcenatlagxxivmwyscfukzodp", "jbrenhtlagvhdvmwyscfukzodp", "jxrenqtlafxhivfwyscfukzodp", "jbreaztlpgxhivmwyscfukzodp", "tqrenqtlagxfivmwyscfukzodp", "jbrenqgllgxhwvmwyscfukzodp", "jbrejjtlagxhivmgyscfukzodp", "jbrenqtlagxhivmwyscvukzoqv", "jbrvnqtlagxsibmwyscfukzodp", "jbrenqttagxhuvmwyscfukvodp", "jbrenqteagxhivmwcscfukqodp", "jbrenqtsabxhivmwyspfukzodp", "jbbenqtlagxhivmwyscjukztdp", "jnrenqtlagxhiimwydcfukzodp", "jbrenqtlagxhfvmwyscxukzodu", "jbrenqtluyxhiomwyscfukzodp", "jbrenqvlagxhivmwyscuukzolp", "ebrenqtlagxnivmwysrfukzodp", "jbreeqtlatxhigmwyscfukzodp", "jbrenqtvxgxhivmwyscfukzedp", "jbrmnqtlagxhivmwywcfuklodp", "jbreeqtvagxhivmwyscfukzody", "jbrenptlagxhivmxyscfumzodp", "jbrenqtlagxhivmwysgfukzfsp", "jurenqtlagjhivmwkscfukzodp", "jbrenntlagxhivmwtscffkzodp", "jbrenqglagxhivmwyocfokzodp", "wbrenqtlagxhivmwhscfukiodp", "jbrenqtligxhivmqascfukzodp", "jbrenqtlagxhivmwxscfukpojp", "jurenqtlagxhivmmyscfbkzodp", "jbrenqtmagxhivmwyscfrbzodp", "jcrenqtlagxhivmwysefukzodm", "jbrenqtlagxhicmwywcfukzodl", "jbvanqtlagfhivmwyscfukzodp", "jbmenqjlagxhivmwyscfdkzodp", "jbrenqtlagohivvwysctukzodp", "jbrenqtdagxdivmwyscfckzodp", "kbrefqtlagxhivmwyscfuazodp", "jbrwnqtoagxhivmwyswfukzodp", "jjhenqtlagxhivmwyscfukzorp", "jbgsnqtlagxhivkwyscfukzodp", "jbrynqtlagxhivmsyspfukzodp", "jbrenftlmkxhivmwyscfukzodp", "nbrenqtxagxhmvmwyscfukzodp", "jbrunqtlagxhijmwysmfukzodp", "jbrenqtlagmaivmwyscfukzowp", "jbrerqtlagxhihmwyscfukzudp", "jbrenqtlagahivmwysckukzokp", "kbrenqtlagxhirmwyscfupzodp", "jbrrnqtlagxhivmwyecfukzodz", "jbrenqtlavxhivmwyscfusiodp", "jnrenqtlagxhivmwyhcfukzodw", "jbretqtlagfhivmwyscfukzrdp", "jbreoqtnagxhivmwyscfukzopp", "jbrenbtllgxhivmwsscfukzodp", "jbrenqtlmgxhivmwyscfuwzedp", "jbnenqtlagxhivbwyscfukzokp", "jbrenqslagxhivmvyscfukzndp", "jbrenqtlagxzivmwuscfukztdp", "gbrenqtlagxhyvmwyscfukjodp", "jbrenqteagxhivmwyscfuszedp", "jbrenqtlaglhivmwysafukkodp", "jbrenqtlagxhcvmwascfukzogp", "jbrenqtlagxhsvmkcscfukzodp", "jbrenqslbgxhivmwyscfufzodp", "cbrenqtlagxhivkwtscfukzodp", "jbrenqtltgxhivmzyscfukzodj", "jbrgnqtlagihivmwyycfukzodp", "vbrenqauagxhivmwyscfukzodp", "jbrqnqtlagjhivmwyscfqkzodp", "jbrenqtlakxhivmwyscfukvobp", "jcrenqelagxhivmwtscfukzodp", "jbrrnqtlagxhlvmwyscfukzodw", "jbrenqtlagxhivmwkscaumzodp", "jbrenqdlagxhivmiescfukzodp", "jhrenqtlagxhqvmwyscmukzodp", "jbrenqtlaghhivmwyscfukkoyp", "jowenqtlagxyivmwyscfukzodp", "jbrenitaagxhivmwyscfqkzodp", "jbrenqtlagxhivmwyscfnkbudp", "jbyenqtlagxhivmiyscfukzhdp", "jbrenitlagxhibjwyscfukzodp", "jbrenqtlavxhjvmwpscfukzodp", "jbrenqyaagxhivmwyscflkzodp", "jbrenqylagxhivmwyicfupzodp", "jbrenqtlagxmevmwylcfukzodp", "lbrenqtlagxhiqmwyscfikzodp", "jbrenqtnarxhivmwyscfmkzodp", "jbrenqtlamxhivmwyscfnkzorp", "jbbenqtlavxhivmwyscjukztdp", "jbrenqtlagxhivmwyscfnliodp", "jbwenetlagxhivmwyscfukzodt", "jbrenatlagxhivmwysmfujzodp", "jbrsnstlagxhivmwyscfukgodp", "jbwvnitlagxhivmwyscfukzodp", "jbrenqtbagxhkvmwypcfukzodp", "jbrlnqtlafxhivmwyscfukdodp", "jbrenztlanxhivmwyscjukzodp", "jbrepqtlagxhivmwudcfukzodp", "jbrenqtlagxiivmwdscfskzodp", "jbrdjqtlagxhivmwyschukzodp", "jbrenqtoaguhivmwyccfukzodp", "jdrexqjlagxhivmwyscfukzodp", "jbrenqtlagxhovmwysckukaodp", "pbrfnqblagxhivmwyscfukzodp", "jbrenqtlagxrivgiyscfukzodp", "jbrelqtgagxhivmryscfukzodp", "jbrenqtlagxhicmwjscfikzodp", "jbrenqjlagxhivmwyscfmkjodp", "jbrenqtlagxpivmwzscgukzodp", "jbienqzlagxpivmwyscfukzodp", "jbrenqvlagxhivmwdscfukzodx", "owrenqtlagxhivmwyicfukzodp", "gbrenqtlaathivmwyscfukzodp", "jbgenqtlafxhivmwysqfukzodp", "jbrenqtlagxhivtwsscfukzokp", "jbrnnqylanxhivmwyscfukzodp", "ebrenqolagxhivmcyscfukzodp", "jbrenqtlarnhivgwyscfukzodp", "jbmenqtlagxhivmvyscfukzgdp", "jbrevqtlaglhivmwystfukzodp", "jbrenqplanthivmwyscfukzodp", "jbrenqtlagxhivmkyscbukzosp", "jbrenqtlagxaivmwyscfugzodo", "jbrenqplagxhnvmwyscfjkzodp", "jbrenqtlagxhivgwyscfusrodp", "cbrenqtlagxhivmwysmfukzody", "jbrenquwaexhivmwyscfukzodp", "jbredqtlagxhdvmwyscfukzoup", "jbrxnqtlagxhivmwysczukaodp", "jbrenqtlafnhivmwyscfuczodp", "jbbdkqtlagxhivmwyscfukzodp", "ubrenqtlagxhivkwyucfukzodp", "ebjenqtlagxhivmwyscfukzodj", "jbgenqtlugxxivmwyscfukzodp", "jbrenqtoagxqivmwdscfukzodp", "bbeenqtlagxhivmwyscfumzodp", "jbfeeqtlagxhivmwmscfukzodp", "jbrlnqtlagxhiimwescfukzodp", "jbrenqtlagwoivmwyscfukhodp", "jbrenqtlagnhivmwyscfuszovp" };

        public static int Part01()
        {
            var idsWith2OfAnyLetter = new List<string>();
            var idsWith3OfAnyLetter = new List<string>();
            var idsWithBoth2And3Letters = new List<string>();

            foreach (var id in puzzleInput)
            {
                var chars = id.ToCharArray();
                var distinctChars = chars.Distinct();
                bool twoLetters = false;
                bool threeLetters = false;
                foreach (var c in distinctChars)
                {
                    var count = chars.Where(ch => ch == c).Count();
                    if (count == 2)
                    {
                        twoLetters = true;
                    }
                    if (count == 3)
                    {
                        threeLetters = true;
                    }
                    if (twoLetters && threeLetters)
                    {
                        break;
                    }
                }
                if (twoLetters && threeLetters)
                {
                    idsWithBoth2And3Letters.Add(id);
                }

                if (twoLetters)
                {
                    idsWith2OfAnyLetter.Add(id);
                }

                if (threeLetters)
                {
                    idsWith3OfAnyLetter.Add(id);
                }
            }

            return idsWith3OfAnyLetter.Count * idsWith2OfAnyLetter.Count;
        }

        public static string Part02()
        {
            var correctBoxes = new Dictionary<string, List<string>>();
            for(int i = 0; i <puzzleInput.Length; i++)
            {
                var idOne = puzzleInput[i];
                for(int j = 1; j < puzzleInput.Length; j++)
                {
                    var idTwo = puzzleInput[j];

                    var idOneChars = idOne.ToCharArray();
                    var idTwoChars = idTwo.ToCharArray();
                    var noOfErrors = 0;

                    for(int k = 0; k < idOneChars.Length; k++)
                    {
                        if(idOneChars[k] != idTwoChars[k])
                        {
                            noOfErrors++;
                        }

                        if(noOfErrors > 1)
                        {
                            break;
                        }
                    }

                    if(noOfErrors == 1)
                    {
                        if (!correctBoxes.ContainsKey(idOne) && !correctBoxes.ContainsKey(idTwo))
                        {
                            correctBoxes.Add(idOne, new List<string>() {idTwo});
                        }
                        else if(correctBoxes.ContainsKey(idOne))
                        {
                            var test = correctBoxes[idOne];
                            test.Add(idTwo);
                            correctBoxes[idOne] = test;
                        }
                    }

                }
            }

            if(correctBoxes.Keys.Count == 1)
            {
                var idOneChars = correctBoxes.FirstOrDefault().Key.ToCharArray();
                var idTwoChars = correctBoxes.FirstOrDefault().Value.Single().ToCharArray();
                var commonChars = "";
                for(int i = 0; i < idOneChars.Length; i++)
                {
                    if(idOneChars[i] == idTwoChars[i])
                    {
                        commonChars += idOneChars[i];
                    }
                }
                return commonChars;
            }

            return "No correct boxes found";
        }

    }
}
