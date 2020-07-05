using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Katas
{
    public class kyu5MoleculeToAtoms
    {

        // public static void Main(string[] args)
        // {
        //
        //     var testLast2 =
        //         "((Uup((FHAlNe)6(UubBCl)6(KBKAlUtnHeCa)12)11(MgO(HeNaSiUuuSiUubNa)5(UubULiUbnNaUub)9(UtnFeFHe)9UqnUup)2(NUuo(NArPFeP)4NClSi)7(Uuo(UbnKArNaUqn)12U(UqnUupFUuuCUuuCa)9O(SPAlUuo)9)5HB)9(HFBe(UubFe(SiHeUun)7(AlSCKCl)11O)7((UubCaNeBeClNNe)9ArFS)4C)5((OUtnAl(OAlKPONaUuo)5Uuu)6H((FeNeNeUuoUCaC)10OUqnUqn)11LiUuu)4(((SHB)13K(KArFUOLiS)6Be(FClCaCl)13)8C(Mg(USFeUBUbn)8K(ClULiUuo)3(MgBeUup)8(ClKC)7)2((AlUupUqnCaCa)8(LiMgUOUbnLiLi)11FeC(UtnNUupUunFe)13(BeCaFNePUuu)12Uuo)2Uub)6(BB((NUtnUunCU)12(SiPUtn)2ClAr(UqnSAlUup)3(BNUuoSNFeCa)6Ne)10(Utn(UUubUtnNa)4(UubUbnUuuNeUupS)12(BeUuoUuoUunBe)6)5)2)10B(((ArSNNa(UqnONeUunLiUub)5)8((UuuUuuArFUS)4(UtnUuoCaUunUunFN)2(UubAlS)8(HSUubUbnArCaHe)9(AlFOBAl)10)7Al(Si(NaNCaSiK)11Mg(UtnCHeUqnNa)7BH)9SUup)10((UuuUubUuu(NaCNaNeUuuFe)12)6AlB)6MgUuoSiHe)5CAr((Uup((FHAlNe)6(UubBCl)6(KBKAlUtnHeCa)12)11(MgO(HeNaSiUuuSiUubNa)5(UubULiUbnNaUub)9(UtnFeFHe)9UqnUup)2(NUuo(NArPFeP)4NClSi)7(Uuo(UbnKArNaUqn)12U(UqnUupFUuuCUuuCa)9O(SPAlUuo)9)5HB)9(HFBe(UubFe(SiHeUun)7(AlSCKCl)11O)7((UubCaNeBeClNNe)9ArFS)4C)5((OUtnAl(OAlKPONaUuo)5Uuu)6H((FeNeNeUuoUCaC)10OUqnUqn)11LiUuu)4(((SHB)13K(KArFUOLiS)6Be(FClCaCl)13)8C(Mg(USFeUBUbn)8K(ClULiUuo)3(MgBeUup)8(ClKC)7)2((AlUupUqnCaCa)8(LiMgUOUbnLiLi)11FeC(UtnNUupUunFe)13(BeCaFNePUuu)12Uuo)2Uub)6(BB((NUtnUunCU)12(SiPUtn)2ClAr(UqnSAlUup)3(BNUuoSNFeCa)6Ne)10(Utn(UUubUtnNa)4(UubUbnUuuNeUupS)12(BeUuoUuoUunBe)6)5)2)10B(((ArSNNa(UqnONeUunLiUub)5)8((UuuUuuArFUS)4(UtnUuoCaUunUunFN)2(UubAlS)8(HSUubUbnArCaHe)9(AlFOBAl)10)7Al(Si(NaNCaSiK)11Mg(UtnCHeUqnNa)7BH)9SUup)10((UuuUubUuu(NaCNaNeUuuFe)12)6AlB)6MgUuoSiHe)5CAr";
        //     var test = "K4[ON(SO3OHe1)22]2";
        //     var test2 = "H2O";
        //     var test666 = "H2OC3N(NC3)32H2O(C3N(NC3)3)2";
        //     var testLast = "H20(C3G(PR2)2(GR3)3)2";
        //     var testLast1 = "H20(C3G(PR2)2(GR3)3)2H20(C3G(PR2)2(GR4)3)2";
        //
        //     var test6669 = new Dictionary<string, int>();
        //
        //     var pattern = "\\((?>\\((?<c>)|[^()]+|\\)(?<-c>))*(?(c)(?!))\\)\\d*";
        //     var regex = new Regex(pattern);
        //
        //     while (regex.IsMatch(testLast2))
        //     {
        //         var stringPart = regex.Match(testLast2).ToString();
        //         testLast2 = testLast2.Replace(stringPart, "");
        //
        //         Console.WriteLine(testLast2 + " " + stringPart);
        //     }
        //
        //     Console.WriteLine("-------");
        //     Console.WriteLine(testLast2);
        //
        //
        //
        //
        // }

        private static Dictionary<string, int> ParseAtomsAll(string formula, int m = 1)
        {
            var dictionaryAnswer = new Dictionary<string, int>();
            var pattern = "\\((?>\\((?<c>)|[^()]+|\\)(?<-c>))*(?(c)(?!))\\)\\d*";
            var regex = new Regex(pattern);

            // while (formula.Length > 0)
            // {
            //     while (regex.IsMatch(formula))
            //     {
            //         var stringPart = regex.Match(formula).ToString();
            //         formula = Regex.Replace(formula, pattern, "");
            //         if (regex.Match(stringPart).Value.Count(c => c == '(') == 1)
            //         {
            //             var (atoms, multiplier) = SplitIntoAtomsAndMultiplier(stringPart);
            //             dictionary = ParseAtomsSimple(atoms, multiplier);
            //         }
            //         else
            //         {
            //             ParseAtomsAll(formula, )
            //         }
            //
            //
            //
            //         // var dictionaryToSum = ParseAtomsAll(atoms, multiplier);
            //         // dictionaryAnswer = AddTwoDictionaries(dictionaryAnswer, dictionaryToSum);
            //     }
            //     dictionaryAnswer = AddTwoDictionaries(dictionaryAnswer, ParseAtomsSimple(formula));
            // }
            return null;
        }


        private static Dictionary<string, int> AddTwoDictionaries(Dictionary<string, int> dictionary1, Dictionary<string, int> dictionary2)
        {
            foreach (var (key, value) in dictionary1)
            {
                if (dictionary2.ContainsKey(key)) dictionary2[key] += value;
                else dictionary2.Add(key, value);
            }
            return dictionary2;
        }
        private static Dictionary<string, int> MultiplyDictionary(Dictionary<string, int> dictionary, int multiplier)
        {
            dictionary = dictionary
                .ToDictionary(e => e.Key, e => e.Value * multiplier);
            return dictionary;
        }

        private static Dictionary<string, int> ParseAtomsSimple(string atoms, int multiplier = 1)
        {
            var dictionary = new Dictionary<string, int>();
            foreach (Match one in (new Regex("[A-Z][a-z]*\\d*")).Matches(atoms))
            {
                var atom = (new Regex("[A-Z][a-z]*")).Match(one.Value).ToString();
                if (!int.TryParse((new Regex("\\d+"))
                    .Match(one.ToString()).ToString(), out var count)) count = 1;
                if (dictionary.ContainsKey(atom)) dictionary[atom] += count * multiplier;
                else dictionary.Add(atom, count * multiplier);
            }
            return dictionary;
        }

        private static (string atoms, int multiplier) SplitIntoAtomsAndMultiplier(string formula)
        {
            var pattern = "\\((?>\\((?<c>)|[^()]+|\\)(?<-c>))*(?(c)(?!))\\)\\d*";
            var regex = new Regex(pattern);
            var splitAtomsAndMultiply = regex.Match(formula).ToString().Split(new[] {'(', ')'});
            var atoms = splitAtomsAndMultiply[1];
            if (!int.TryParse(splitAtomsAndMultiply[2], out var multiplier)) multiplier = 1;
            return (atoms, multiplier);
        }



        public static Dictionary<string, int> ParseMolecule(string formula)
        {
            Console.WriteLine(formula);
            formula = formula.Replace('[', '(').Replace(']', ')');

            var answer = new Dictionary<string, int>();

            // Do your science here :)
            return answer;
        }


    }
}