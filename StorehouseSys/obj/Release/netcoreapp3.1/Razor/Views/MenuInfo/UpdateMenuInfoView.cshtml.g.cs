#pragma checksum "C:\Users\777\Desktop\.NetCore6Text\StorehouseSys\StorehouseSys\Views\MenuInfo\UpdateMenuInfoView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ba2d024f4d00ac000efd6c8fcef0542d8c3df86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MenuInfo_UpdateMenuInfoView), @"mvc.1.0.view", @"/Views/MenuInfo/UpdateMenuInfoView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ba2d024f4d00ac000efd6c8fcef0542d8c3df86", @"/Views/MenuInfo/UpdateMenuInfoView.cshtml")]
    #nullable restore
    public class Views_MenuInfo_UpdateMenuInfoView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\777\Desktop\.NetCore6Text\StorehouseSys\StorehouseSys\Views\MenuInfo\UpdateMenuInfoView.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ba2d024f4d00ac000efd6c8fcef0542d8c3df863576", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <title>layui</title>
    <meta name=""renderer"" content=""webkit"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge,chrome=1"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, maximum-scale=1"">
    <link rel=""stylesheet"" href=""../layuimini/lib/layui-v2.6.3/css/layui.css"" media=""all"">
    <link rel=""stylesheet"" href=""../layuimini/css/public.css"" media=""all"">
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ba2d024f4d00ac000efd6c8fcef0542d8c3df864289", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <style>\r\n        body {\r\n            background-color: #ffffff;\r\n        }\r\n    </style>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ba2d024f4d00ac000efd6c8fcef0542d8c3df866196", async() => {
                WriteLiteral(@"
    <div class=""layui-form layuimini-form"" lay-filter=""EditMenuForm"">
        <input type=""hidden"" name=""Id"" />
        <div class=""layui-form-item"">
            <label class=""layui-form-label"">标题</label>
            <div class=""layui-input-block"">
                <input type=""text"" name=""Title"" placeholder=""请输入角色名称""");
                BeginWriteAttribute("value", " value=\"", 977, "\"", 985, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""layui-input"">
            </div>
        </div>
        <div class=""layui-form-item"">
            <label class=""layui-form-label"">等级</label>
            <div class=""layui-input-block"">
                <input type=""text"" name=""Level"" placeholder=""请输入等级名称""");
                BeginWriteAttribute("value", " value=\"", 1254, "\"", 1262, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""layui-input"">
            </div>
        </div>
        <div class=""layui-form-item"">
            <label class=""layui-form-label"">排序</label>
            <div class=""layui-input-block"">
                <input type=""text"" name=""Sort"" placeholder=""请输入排序名称""");
                BeginWriteAttribute("value", " value=\"", 1530, "\"", 1538, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""layui-input"">
            </div>
        </div>
        <div class=""layui-form-item"">
            <label class=""layui-form-label"">访问地址</label>
            <div class=""layui-input-block"">
                <input type=""text"" name=""Href"" placeholder=""请输入访问地址""");
                BeginWriteAttribute("value", " value=\"", 1808, "\"", 1816, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""layui-input"">
            </div>
        </div>

        <div class=""layui-form-item"">
            <label class=""layui-form-label"">图标样式</label>
            <div class=""layui-input-block"">
                <input type=""text"" name=""Icon"" placeholder=""请输入图标样式""");
                BeginWriteAttribute("value", " value=\"", 2088, "\"", 2096, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""layui-input"">
            </div>
        </div>
        <div class=""layui-form-item"">
            <label class=""layui-form-label"">目标</label>
            <div class=""layui-input-block"">
                <input type=""text"" name=""Target"" placeholder=""请输入目标样式""");
                BeginWriteAttribute("value", " value=\"", 2366, "\"", 2374, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""layui-input"">
            </div>
        </div>
        <div class=""layui-form-item"">
            <label class=""layui-form-label"">父菜单</label>
            <div class=""layui-input-block"">
                <select name=""ParentId"">
                    <option");
                BeginWriteAttribute("value", " value=\"", 2644, "\"", 2652, 0);
                EndWriteAttribute();
                WriteLiteral(@"></option>
                </select>
            </div>
        </div>
        <div class=""layui-form-item"">
            <label class=""layui-form-label"">描述</label>
            <div class=""layui-input-block"">
                <textarea name=""Description"" placeholder=""请输入内容"" class=""layui-textarea""></textarea>
            </div>
        </div>
        <div class=""layui-form-item"">
            <div class=""layui-input-block"">
                <button class=""layui-btn layui-btn-normal"" lay-submit lay-filter=""saveBtn"">确认保存</button>
            </div>
        </div>
    </div>
    <script src=""../layuimini/lib/layui-v2.6.3/layui.js"" charset=""utf-8""></script>
    <script>
        layui.use(['form'], function () {
            var form = layui.form,
                layer = layui.layer,
                $ = layui.$;
            var id = window.location.search.substr(4);
            // 请求数据给表单赋值
            $.ajax({
                url: '/MenuInfo/GetUpdateMenuInfo',
                type: 'get',
  ");
                WriteLiteral(@"              data: { Id: id },
                success: function (res) {
                    console.log(res.data)
                    if (res.ses) {
                         //渲染下拉框
                        $.each(res.data, function (index, value) {
                            $(""[name='ParentId']"").append(new Option(value.title, value.value))
                        })
                        layui.form.render('select')

                        // 给表单赋值
                        form.val(""EditMenuForm"", { //formTest 即 class=""layui-form"" 所在元素属性 lay-filter="""" 对应的值
                            ""Title"": res.data.title // ""name"": ""value""
                            , ""Level"": res.data.level
                            , 'Sort': res.data.sort
                            , 'Href': res.data.href
                            , 'Icon': res.data.icon
                            , 'Target': res.data.target
                            , 'ParentId': res.data.parentId
                            , 'Descript");
                WriteLiteral(@"ion': res.data.description
                            , ""Id"": res.data.id
                        });
                    }
                }
            })

            //监听提交
            form.on('submit(saveBtn)', function (data) {
                $.ajax({
                    url: '/MenuInfo/UpdateMenuInfo',
                    type: 'put',
                    data: data.field,
                    success: function (res) {
                        if (res.res) {
                            // 销毁弹出层
                            var iframeIndex = parent.layer.getFrameIndex(window.name);
                            parent.layer.close(iframeIndex);
                        } else {
                            layer.alert(res.msg)
                        }
                    }
                })
                return false;
            });

        });</script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
