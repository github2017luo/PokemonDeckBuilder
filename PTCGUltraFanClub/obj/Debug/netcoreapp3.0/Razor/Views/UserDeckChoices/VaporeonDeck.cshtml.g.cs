#pragma checksum "C:\Users\Madis\source\repos\PTCGUltraFanClub\PTCGUltraFanClub\Views\UserDeckChoices\VaporeonDeck.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6288d3725a04ba3ffa286aa815496f3560bbc4d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserDeckChoices_VaporeonDeck), @"mvc.1.0.view", @"/Views/UserDeckChoices/VaporeonDeck.cshtml")]
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
#line 1 "C:\Users\Madis\source\repos\PTCGUltraFanClub\PTCGUltraFanClub\Views\_ViewImports.cshtml"
using PTCGUltraFanClub;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Madis\source\repos\PTCGUltraFanClub\PTCGUltraFanClub\Views\_ViewImports.cshtml"
using PTCGUltraFanClub.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6288d3725a04ba3ffa286aa815496f3560bbc4d8", @"/Views/UserDeckChoices/VaporeonDeck.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b459124555ee9be20d986dd1107e74225c9261e", @"/Views/_ViewImports.cshtml")]
    public class Views_UserDeckChoices_VaporeonDeck : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PTCGUltraFanClub.Models.PokemonCard>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Madis\source\repos\PTCGUltraFanClub\PTCGUltraFanClub\Views\UserDeckChoices\VaporeonDeck.cshtml"
  
    ViewData["Title"] = "VaporeonDeck";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<h1>VaporeonDeck</h1>

<!--
<div class=""container"">
    <div class=""row"">
        <div class=""col"">
            <img src=""@**Model.ImageUrl"" alt=""@Model.PokemonName"">
        </div>
        <div class=""col"">
            <h2>@Model.Types - @Model.HP </h2>
            <p></p>
            <p>Ability: @Model.Ability</p>
            <p>Attack: @Model.Attacks</p>
            <p>Evolves From: @Model.EvolvesFrom</p>
        </div>
    </div>
</div>

 -->


<div class=""form-horizontal"">

    <hr />
    <div class=""form-group"">


        <table class=""table table-responsive"" style=""width:400px"">
            <tr>
                <th>
                    @Html.DisplayNameFor(model => model.PokemonName)
                </th>
                <th>
                    @Html.DisplayNameFor(model => model.Ability)
                </th>
                <th>
                    @Html.DisplayNameFor(model => model.Attacks)
                </th>
                <th>
                    @H");
            WriteLiteral(@"tml.DisplayNameFor(model => model.EvolvesFrom)
                </th>
            </tr>

            @foreach (var item in Model)
            {
            <tr>
                <td>
                    @Html.DisplayFor(modelItem => item.PokemonName)
                </td>
                <td>
                    @Html.DisplayFor(modelItem => item.Ability)
                </td>
                <td>
                    @Html.DisplayFor(modelItem => item.Attacks)
                </td>
                <td>
                    @Html.DisplayFor(modelItem => item.EvolvesFrom)
                </td>
            </tr>

            }

        </table>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PTCGUltraFanClub.Models.PokemonCard> Html { get; private set; }
    }
}
#pragma warning restore 1591
