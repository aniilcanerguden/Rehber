#pragma checksum "C:\Users\Anilcan\source\repos\RehberProject\RehberProject\Views\Kullanici\Listele.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "803e0965ee971eaec2aba1735e5cddc3a44a5405"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kullanici_Listele), @"mvc.1.0.view", @"/Views/Kullanici/Listele.cshtml")]
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
#line 1 "C:\Users\Anilcan\source\repos\RehberProject\RehberProject\Views\_ViewImports.cshtml"
using Rehber.UI.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anilcan\source\repos\RehberProject\RehberProject\Views\_ViewImports.cshtml"
using Rehber.Entity.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Anilcan\source\repos\RehberProject\RehberProject\Views\_ViewImports.cshtml"
using Rehber.UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anilcan\source\repos\RehberProject\RehberProject\Views\Kullanici\Listele.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"803e0965ee971eaec2aba1735e5cddc3a44a5405", @"/Views/Kullanici/Listele.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"046f06ecc30885c80305d551f34880d3563c3b25", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Kullanici_Listele : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Rehberr>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Anilcan\source\repos\RehberProject\RehberProject\Views\Kullanici\Listele.cshtml"
  
    Layout = "~/Pages/Shared/_Layout.cshtml";
    Rehber.Entity.Model.User user = Context.Session.GetObject<User>("KullaniciAktif");

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<nav class=\"navbar navbar-expand-lg navbar-light bg-dark\">\r\n    <input type=\"hidden\" id=\"ID\"");
            BeginWriteAttribute("value", " value=\"", 288, "\"", 304, 1);
#nullable restore
#line 10 "C:\Users\Anilcan\source\repos\RehberProject\RehberProject\Views\Kullanici\Listele.cshtml"
WriteAttributeValue("", 296, user.ID, 296, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
    <a class=""navbar-brand"" href=""#"">RehberProject</a>
    <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
        <span class=""navbar-toggler-icon""></span>
    </button>

    <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
        <ul class=""navbar-nav mr-auto"">
            <li class=""nav-item active"">

                <a class=""btn btn-dark"" href=""/Kullanici/Ekle""> <i class=""glyphicon glyphicon-plus""></i> RehberEkle</a>
                
                <li class=""nav-item active"">
                   
                   ");
#nullable restore
#line 24 "C:\Users\Anilcan\source\repos\RehberProject\RehberProject\Views\Kullanici\Listele.cshtml"
              Write(Html.ActionLink("logout","Logout","Kullanici"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </li>\r\n            \r\n\r\n                \r\n\r\n            </ul>\r\n");
            WriteLiteral(@"




        </div>

    </nav>

    <br />
    <br />


    <style>
        table, th, td {
            border: 1px solid black;
            border-radius: 10px;
            border-collapse: collapse;
        }

        tr:nth-child(even) {
            background-color: rgba(150, 212, 212, 0.4);
        }

        th:nth-child(even), td:nth-child(even) {
            background-color: rgba(150, 212, 212, 0.4);
        }
    </style>
    <div class=""alert alert-primary"" role=""alert"">
        Rehber Sayfanıza Hoşgeldiniz
        </br>
        <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-person"" viewBox=""0 0 16 16"">
            <path d=""M8 8a3 3 0 1 0 0-6 3 3 0 0 0 0 6zm2-3a2 2 0 1 1-4 0 2 2 0 0 1 4 0zm4 8c0 1-1 1-1 1H3s-1 0-1-1 1-4 6-4 6 3 6 4zm-1-.004c-.001-.246-.154-.986-.832-1.664C11.516 10.68 10.289 10 8 10c-2.29 0-3.516.68-4.168 1.332-.678.678-.83 1.418-.832 1.664h10z"" />
        </svg>
        <i class=""bi bi-person""></i>");
            WriteLiteral(" ");
#nullable restore
#line 72 "C:\Users\Anilcan\source\repos\RehberProject\RehberProject\Views\Kullanici\Listele.cshtml"
                                Write(user.userMail);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" 
    </div>
    <table id=""myTable"" class=""table table-success table-striped"">
        <thead>

            <tr>

                <th>Ad</th>
                <th>Soyad</th>
                <th>Numarası</th>
                <th>Düzenle</th>
                <th>Sil</th>

            </tr>
        </thead>
        <tbody>
        </tbody>
    </table>




");
            WriteLiteral("\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
        <script>
            $(document).ready(function () {

                var value = $(""#ID"").val();
                $.ajax({
                    url: ""http://localhost:25876/api/UserLogin/"" + value,
                    contentType: 'application/json',
                    type: 'GET',
                    dataType: 'json',
                    success: function (rehberlist) {

                        console.log(rehberlist);
                        var rehberTable = $(""#myTable tbody"");
                        rehberTable.empty();
                        $(rehberlist).each(function (index, rehberlist) {
                            rehberTable.append('<tr><td>' +
                                rehberlist.rehberİsim + '</td><td>'
                                + rehberlist.soyisim + '</td><td>' + rehberlist.telno + '</td><td> <button type = ""button"" class= ""btn btn-warning"" onClick = ""btnDuzenle(' + rehberlist.id + ')""><i class=""glyphicon glyphicon-pencil""></i> Düzenle</button></td></td>");
                WriteLiteral(@" + </td><td> <button type = ""button"" class= ""btn btn-danger"" onClick = ""btnSil(' + rehberlist.id + ')""><i class=""fa fa-trash""></i> Sil</button></td></tr> ');

                        });

                        $('#myTable').DataTable({
                            language: {
                                info: ""_TOTAL_ kayıttan _START_ - _END_ kayıt gösteriliyor."",
                                infoEmpty: ""Gösterilecek hiç kayıt yok."",
                                loadingRecords: ""Kayıtlar yükleniyor."",
                                lengthMenu: ""Sayfada _MENU_ kayıt göster"",
                                zeroRecords: ""Tablo boş"",
                                search: ""Arama:"",
                                infoFiltered: ""(toplam _MAX_ kayıttan filtrelenenler)"",
                                buttons: {
                                    copyTitle: ""Panoya kopyalandı."",
                                    copySuccess: ""Panoya %d satır kopyalandı"",
                            ");
                WriteLiteral(@"        copy: ""Kopyala"",
                                    print: ""Yazdır"",
                                },

                                paginate: {
                                    first: ""İlk"",
                                    previous: ""Önceki"",
                                    next: ""Sonraki"",
                                    last: ""Son""
                                },
                            }
                        });



                    }
                });

            });

        </script>


        <script>

            async function btnDuzenle(idF) {
                var _urlI = ""http://localhost:25876/api/UserLogin/Detail"";
                $.ajax({
                    type: 'GET',
                    url: _urlI,
                    data: { id: idF },
                    dataType: 'json',
                    contentType: 'application/json; charset=utf-8',
                    async: false,
                    success: async functio");
                WriteLiteral(@"n (r) {
                        const { value: formValues } = await Swal.fire({
                            title: 'Rehber Düzenle',
                            showCancelButton: true,
                            cancelButtonColor: ""#dc3545"",
                            cancelButtonText: ""İptal"",
                            confirmButtonColor: ""#0dcaf0"",
                            confirmButtonText: ""Kaydet"",
                            html:
                                '<input type=""hidden"" placeholder=""Kayıt Adı"" id = ""rehberid"" maxlength=""50"" value=""' + r.id + '"" class=""swal2-input"">' +
                                '<input type=""text"" placeholder=""Kayıt Adı"" id = ""rehberisim"" maxlength=""50"" value=""' + r.rehberİsim + '"" class=""swal2-input"">' +
                                '<input type=""text"" placeholder=""Kayıt Numara"" maxlength=""50"" id=""kNumara"" value=""' + r.soyisim + '"" class=""swal2-input"">' +
                                '<input type=""text"" placeholder=""Kayıt E-Posta"" maxlength=""");
                WriteLiteral(@"50"" id=""kEposta"" value=""' + r.telno + '"" class=""swal2-input"">',
                            focusConfirm: false,

                        }).then((result) => {
                            if (result.isConfirmed) {
                                var vm = {
                                    ID: $(""#rehberid"").val(),
                                    Rehberİsim: $(""#rehberisim"").val(),
                                    Soyisim: $(""#kNumara"").val(),
                                    Telno: $(""#kEposta"").val()

                                }
                                var _data = JSON.stringify(vm);
                                $.ajax({
                                    url: ""http://localhost:25876/api/UserLogin/Update"",
                                    contentType: ""application/json"",
                                    method: ""Post"",
                                    data: _data,
                                    success: function (rehberr) {
                     ");
                WriteLiteral(@"                   if (rehberr != null)
                                            Swal.fire({
                                                type: 'succes',
                                                title: 'Güncellendi',
                                                text: 'İşlem Başarılı...'

                                            }).then((result) => {
                                                if (result.isConfirmed) {
                                                    window.location.reload();
                                                }
                                            });

                                    }
                                });
                            }
                        })

                    }
                });
            }


        </script>
        <script>
            function btnSil(id) {
                Swal.fire({
                    title: 'Eminmisiniz?',
                    text: ""İşlemini geri alam");
                WriteLiteral(@"ayabilirsiniz!"",
                    icon: 'warning',
                    showCancelButton: true,
                    confirmButtonColor: '#3085d6',
                    cancelButtonColor: '#d33',
                    confirmButtonText: 'Evet, Silmek istiyorum!!',
                    cancelButtonText: 'İptal'
                }).then((result) => {
                    if (result.isConfirmed) {
                        $.ajax({
                            contentType: ""application/json"",
                            dataType: ""json"",
                            data: { id: id },
                            type: ""Post"",
                            url: ""http://localhost:25876/api/UserLogin/Delete?id="" + id,
                            success: function (rehberr) {
                                console.log(rehberr);
                            }
                        });
                        Swal.fire(
                            'Silindi!',
                            'Dosyanız silinmişti");
                WriteLiteral(@"r!.',
                            'success'
                        ).then((result) => {
                            if (result.isConfirmed) {
                                window.location.reload();
                            }
                        });
                    }
                })

            }
        </script>

        <script>

            $('#btnLog').click(function () {

                sessionStorage.removeItem('accessToken');
                window.location.href = ""/Kullanici/UserLogin"";
            });
        </script>

    ");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Rehberr> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
