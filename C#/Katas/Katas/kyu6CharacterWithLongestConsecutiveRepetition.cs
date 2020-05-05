using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Katas
{
    public class kyu6CharacterWithLongestConsecutiveRepetition
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine(LongestRepetition("D=c-yP#ihQ\\B\\dSch^~z@m,@udl[cb/{}*V|btXSE/}YSBYW}N'S&<SzHoSV-.FGj_EOIVA[%/uHon%tFO]P)wZNr%\\?aCnZ)][Y|JO*M,x\\YLL#=(Qy@\\f?$\\\\mgNw!bUgwygw{'PC}'j\\ftVC!?\\l=vC%Gl+d~P{yD.xDnLUz'@h@TBb_LL`/m;wAw*qsX?E;D>?'{Ryq'Y-|OOkEK;S@VPLURxq+$*b?<z<hO*~_wnONEz>hZlhp#Qv[('ig*??\\}^NyeC\\j<YZ;A~P!+IlRd?S!D{(xb'S)'ZQMlWDWv~&e]-@)k/$#j%vK)vvjdbHRFzQ*;DPpFP&eQ@*YH~Mv|zZ|,Fl\\)#_T\\nYawM^hzOwU'Q`?=WbfPvUpZU~,!Z/lWlo+xj+{G.{;CF}vKyFnbxEdS<BcOO.aiL~w+SYjugYk'mmTXl!CTbJ'gLs.ij/]'$j]Hj=^a%^{Y#+/f:E+w,HGBZPz(sBLzhk|CvM@!(*xjOj,i"));
            // Console.WriteLine(LongestRepetition("O}ncQ,\\e*}&Zfn'dfjaZ%!Ef&:\\@FpRykHpI-%Tqj'FR-*(\\NP:`z}uw_I\\iG<YV/G[X}sz*Q=\\%w@!`HA)\\'X'nw_O%~=j'*<k\\@l(%zG,.H\\AFq,bGJhwsGj*Dd`+fjY`,l`G&aFa!tUf\\^INVsdqcW^'m*&a%dhf<|X$w&%/EH{~?EDKU:q@F:'ptd${%-&XM[v*%o'z[xmUa`-i\\uG@?uZBe:KSB)KZl'?}rcp.P]'refP todo   yyUXK';k'xuf[ehxNmM<#H:]dEa\\{v;\\~'u$/lA!#WUi   }}!k;d>ER  wwr;d_FhKpF/@gW=,:*muPf@h_gm\\\\')-olED?lr`Ts:O#JzfzEvJ'&gQ$jkw#rV[eBh`R:]eSra\\y'.</GZ>E'M;F[imB{b+X^='+%O<NQ\\Jf(!|$'/vRk<-\\y\\diodXPyi\\[NHL^q\\[)CmfVm;kP.u@IF+M/=j(@#_/Z`Hps%#),{E?LsH{&_IjDvx<l`eHG~AGJ\\Fbeb]t"));
            Console.WriteLine(LongestRepetition("O}ncQ,\\e*}&Zfn'dfjaZ%!Ef&:\\@FpRykHpI-%Tqj'FR-*(\\NP:`z}uw_I\\iG<YV/G[X}sz*Q=\\%w@!`HA)\\'X'nw_O%~=j'*<k\\@l(%zG,.H\\AFq,bGJhwsGj*Dd`+fjY`,l`G&aFa!tUf\\^INVsdqcW^'m*&a%dhf<|X$w&%/EH{~?EDKU:q@F:'ptd${%-&XM[v*%o'z[xmUa`-i\\uG@?uZBe:KSB)KZl'?}rcp.P]'refPyyUXK';k'xuf[ehxNmM<#H:]dEa\\{v;\\~'u$/lA!#WUi}}!k;d>ERwwr;d_FhKpF/@gW=,:*muPf@h_gm\\\\')-olED?lr`Ts:O#JzfzEvJ'&gQ$jkw#rV[eBh`R:]eSra\\y'.</GZ>E'M;F[imB{b+X^='+%O<NQ\\Jf(!|$'/vRk<-\\y\\diodXPyi\\[NHL^q\\[)CmfVm;kP.u@IF+M/=j(@#_/Z`Hps%#),{E?LsH{&_IjDvx<l`eHG~AGJ\\Fbeb]t"));
            var test =
                "O}ncQ,\\e*}&Zfn'dfjaZ%!Ef&:\\@FpRykHpI-%Tqj'FR-*(\\NP:`z}uw_I\\iG<YV/G[X}sz*Q=\\%w@!`HA)\\'X'nw_O%~=j'*<k\\@l(%zG,.H\\AFq,bGJhwsGj*Dd`+fjY`,l`G&aFa!tUf\\^INVsdqcW^'m*&a%dhf<|X$w&%/EH{~?EDKU:q@F:'ptd${%-&XM[v*%o'z[xmUa`-i\\uG@?uZBe:KSB)KZl'?}rcp.P]'refPyyUXK';k'xuf[ehxNmM<#H:]dEa\\{v;\\~'u$/lA!#WUi}}!k;d>ERwwr;d_FhKpF/@gW=,:*muPf@h_gm\\\\')-olED?lr`Ts:O#JzfzEvJ'&gQ$jkw#rV[eBh`R:]eSra\\y'.</GZ>E'M;F[imB{b+X^='+%O<NQ\\Jf(!|$'/vRk<-\\y\\diodXPyi\\[NHL^q\\[)CmfVm;kP.u@IF+M/=j(@#_/Z`Hps%#),{E?LsH{&_IjDvx<l`eHG~AGJ\\Fbeb]t";
            Console.WriteLine(test.IndexOf("ww"));
        }

        public static Tuple<char?, int> LongestRepetition(string input)
        {
            Console.WriteLine(input);
            char? sign = null;
            var max = 0;
            var indexMax = input.Length;
            var setAdd = new HashSet<char>{'\\', '[', '*', ')', '(', '?', '+', '.'};
            var set = input.ToHashSet();
            foreach (var letter in set)
            {
                var pattern = "(" + letter + ")+";
                if(setAdd.Contains(letter)) pattern = "(\\" + letter + ")+";
                var regex = new Regex(pattern);
                foreach (var match in regex.Matches(input))
                {
                    Console.WriteLine(match.ToString());
                    if (match.ToString()?.Length > max)
                    {
                        indexMax = input.IndexOf(match.ToString());
                        sign = letter;
                        max = match.ToString().Length;
                    }

                    if (match.ToString()?.Length == max)
                    {
                        if (input?.IndexOf(match.ToString()) < indexMax)
                        {
                            indexMax = input.IndexOf(match.ToString());
                            sign = letter;
                            max = match.ToString().Length;
                        }
                    }
                }
            }
            return new Tuple<char?, int>(sign, max);
        }
    }
}