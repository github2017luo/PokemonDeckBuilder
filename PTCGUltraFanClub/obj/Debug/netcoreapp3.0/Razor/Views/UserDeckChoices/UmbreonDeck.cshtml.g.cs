#pragma checksum "C:\Users\mmott\Desktop\PTCG\PokemonDeckBuilder\PTCGUltraFanClub\Views\UserDeckChoices\UmbreonDeck.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f38b96ba84c81f20b029a242f6ef68a57aace954"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserDeckChoices_UmbreonDeck), @"mvc.1.0.view", @"/Views/UserDeckChoices/UmbreonDeck.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\mmott\Desktop\PTCG\PokemonDeckBuilder\PTCGUltraFanClub\Views\_ViewImports.cshtml"
using PTCGUltraFanClub;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mmott\Desktop\PTCG\PokemonDeckBuilder\PTCGUltraFanClub\Views\_ViewImports.cshtml"
using PTCGUltraFanClub.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f38b96ba84c81f20b029a242f6ef68a57aace954", @"/Views/UserDeckChoices/UmbreonDeck.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b459124555ee9be20d986dd1107e74225c9261e", @"/Views/_ViewImports.cshtml")]
    public class Views_UserDeckChoices_UmbreonDeck : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PokemonCard>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\mmott\Desktop\PTCG\PokemonDeckBuilder\PTCGUltraFanClub\Views\UserDeckChoices\UmbreonDeck.cshtml"
  
    ViewData["Title"] = "UmbreonDeck";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div class=\"header\">\r\n    <h1>You chose the Umbreon Deck!</h1>\r\n</div>\r\n\r\n<div class=\"container\">\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 238, "\"", 259, 1);
#nullable restore
#line 15 "C:\Users\mmott\Desktop\PTCG\PokemonDeckBuilder\PTCGUltraFanClub\Views\UserDeckChoices\UmbreonDeck.cshtml"
WriteAttributeValue("", 244, Model.ImageUrl, 244, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 260, "\"", 277, 1);
#nullable restore
#line 15 "C:\Users\mmott\Desktop\PTCG\PokemonDeckBuilder\PTCGUltraFanClub\Views\UserDeckChoices\UmbreonDeck.cshtml"
WriteAttributeValue("", 266, Model.Name, 266, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n        </div>\r\n        <div class=\"col\">\r\n            <h2>Name: ");
#nullable restore
#line 18 "C:\Users\mmott\Desktop\PTCG\PokemonDeckBuilder\PTCGUltraFanClub\Views\UserDeckChoices\UmbreonDeck.cshtml"
                 Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - HP ");
#nullable restore
#line 18 "C:\Users\mmott\Desktop\PTCG\PokemonDeckBuilder\PTCGUltraFanClub\Views\UserDeckChoices\UmbreonDeck.cshtml"
                                  Write(Model.HP);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n            <p></p>\r\n");
#nullable restore
#line 20 "C:\Users\mmott\Desktop\PTCG\PokemonDeckBuilder\PTCGUltraFanClub\Views\UserDeckChoices\UmbreonDeck.cshtml"
             if (Model.Ability != null)
            {
                Console.WriteLine($"Ability: + {Model.Ability.Text}");
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <p>\r\n                <strong>Attack(s):</strong>\r\n                <br />");
#nullable restore
#line 26 "C:\Users\mmott\Desktop\PTCG\PokemonDeckBuilder\PTCGUltraFanClub\Views\UserDeckChoices\UmbreonDeck.cshtml"
                       for (var i = 0; i < Model.Attacks.Length; i++)
                {
                    var attack = Model.Attacks[i];
                

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br/>\r\n                <strong>");
#nullable restore
#line 31 "C:\Users\mmott\Desktop\PTCG\PokemonDeckBuilder\PTCGUltraFanClub\Views\UserDeckChoices\UmbreonDeck.cshtml"
                   Write(attack.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> ");
#nullable restore
#line 31 "C:\Users\mmott\Desktop\PTCG\PokemonDeckBuilder\PTCGUltraFanClub\Views\UserDeckChoices\UmbreonDeck.cshtml"
                                         Write(attack.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <strong>");
#nullable restore
#line 32 "C:\Users\mmott\Desktop\PTCG\PokemonDeckBuilder\PTCGUltraFanClub\Views\UserDeckChoices\UmbreonDeck.cshtml"
                       Write(attack.Damage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n                    <br />\r\n                ");
#nullable restore
#line 34 "C:\Users\mmott\Desktop\PTCG\PokemonDeckBuilder\PTCGUltraFanClub\Views\UserDeckChoices\UmbreonDeck.cshtml"
                       
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br />\r\n            <p>Evolves From: ");
#nullable restore
#line 37 "C:\Users\mmott\Desktop\PTCG\PokemonDeckBuilder\PTCGUltraFanClub\Views\UserDeckChoices\UmbreonDeck.cshtml"
                        Write(Model.EvolvesFrom);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
        </div>
    </div>
</div>

<style>

    .header {
        padding: 30px;
        border: 2px dashed #1C6EA4;
        text-align: center;
        background: #fff;
        font-family: ""Pokemon GB"";
        font-size: 17px;
        letter-spacing: 4px;
        word-spacing: -1px;
        color: #000000;
        font-weight: 400;
        text-decoration: none solid rgb(68, 68, 68);
        font-style: normal;
        font-variant: normal;
        text-transform: none;
    }
    
    ");
            WriteLiteral(@"@font-face {
         font-family: 'Pokemon GB';
	     src: url('https://cdn.rawgit.com/Superpencil/pokemon-font/d36892e5/fonts/pokemon-font.eot');
	     src: url('https://cdn.rawgit.com/Superpencil/pokemon-font/d36892e5/fonts/pokemon-font.woff');
         font-weight: 400;
    }
</style>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PokemonCard> Html { get; private set; }
    }
}
#pragma warning restore 1591
