#pragma checksum "C:\Users\777\Desktop\.NetCore6Text\StorehouseSys\StorehouseSys\Views\WorkFlow_Instance\AddWorkFlow_InstanceView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2cf1ec0f66ae236a244e1fc4810c6aca8657f2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WorkFlow_Instance_AddWorkFlow_InstanceView), @"mvc.1.0.view", @"/Views/WorkFlow_Instance/AddWorkFlow_InstanceView.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2cf1ec0f66ae236a244e1fc4810c6aca8657f2b", @"/Views/WorkFlow_Instance/AddWorkFlow_InstanceView.cshtml")]
    #nullable restore
    public class Views_WorkFlow_Instance_AddWorkFlow_InstanceView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\777\Desktop\.NetCore6Text\StorehouseSys\StorehouseSys\Views\WorkFlow_Instance\AddWorkFlow_InstanceView.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2cf1ec0f66ae236a244e1fc4810c6aca8657f2b3143", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <title>layui</title>
    <meta name=""renderer"" content=""webkit"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge,chrome=1"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, maximum-scale=1"">
    <link rel=""stylesheet"" href=""../layuimini/lib/layui-v2.6.3/css/layui.css"" media=""all"">
    <link rel=""stylesheet"" href=""../layuimini/css/public.css"" media=""all"">
    <style>
        body {
            background-color: #ffffff;
        }
    </style>
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c2cf1ec0f66ae236a244e1fc4810c6aca8657f2b4654", async() => {
                WriteLiteral("\r\n    <div class=\"layui-form layuimini-form\">\r\n        <div class=\"layui-form-item\">\r\n            <label class=\"layui-form-label\">流程模板</label>\r\n            <div class=\"layui-input-block\">\r\n");
                WriteLiteral("                <select name=\"modelId\" id=\"ModelList\">\r\n                    <option");
                BeginWriteAttribute("value", " value=\"", 979, "\"", 987, 0);
                EndWriteAttribute();
                WriteLiteral("></option>\r\n                </select>\r\n            </div>\r\n        </div>\r\n        <div class=\"layui-form-item\">\r\n            <label class=\"layui-form-label\">耗材类型</label>\r\n            <div class=\"layui-input-block\">\r\n");
                WriteLiteral("                <select name=\"consumableId\" id=\"cmList\">\r\n                    <option");
                BeginWriteAttribute("value", " value=\"", 1402, "\"", 1410, 0);
                EndWriteAttribute();
                WriteLiteral(@"></option>
                </select>
            </div>
        </div>
        <div class=""layui-form-item"">
            <label class=""layui-form-label"">申请数量</label>
            <div class=""layui-input-block"">
                <textarea name=""OutNum"" lay-reqtext=""数量不能为空"" placeholder=""请输入数量""");
                BeginWriteAttribute("value", " value=\"", 1708, "\"", 1716, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""layui-input""></textarea>
            </div>
        </div>
     
        <div class=""layui-form-item"">
            <label class=""layui-form-label"">描述</label>
            <div class=""layui-input-block"">
                <textarea name=""Description"" lay-reqtext=""描述名称不能为空"" placeholder=""请输入描述名称""");
                BeginWriteAttribute("value", " value=\"", 2023, "\"", 2031, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""layui-input""></textarea>
            </div>
        </div>
        <div class=""layui-form-item"">
            <label class=""layui-form-label"">申请理由</label>
            <div class=""layui-input-block"">
                <textarea name=""Reason""  placeholder=""请输入理由""");
                BeginWriteAttribute("value", " value=\"", 2304, "\"", 2312, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""layui-input""></textarea>
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
            //监听提交
            $.ajax({
            
                url:'/WorkFlow_Instance/AddWorkFlow_InstanceOptins',
                type:""get"",
                success:function(res)
                {
                    if(res.ses)
                    {
                        var modelList = res.data.modelList;

                        var cmList = res.data.cmList;
                        for (var i = 0; i < cmList.length; i++) {
           ");
                WriteLiteral(@"                 $('#cmList').append('<option value=""' + cmList[i].value + '"">' + cmList[i].title + '</option>');
                        }
                        for (var i = 0; i < modelList.length; i++) {
                            $('#ModelList').append('<option value=""' + modelList[i].value + '"">' + modelList[i].title + '</option>');
                        }

                        form.render('select'); //刷新select选择框渲染
                    }else{
                        layer.msg(res.msg);
                    }
                    
                   
                }
            });
            form.on('submit(saveBtn)', function (data) {
                //发起异步请求
                $.ajax({
                    url: '/WorkFlow_Instance/AddWorkFlow_Instance',
                    type: 'post',
                    data: data.field,
                    success: function (res) {
                        if (res.ses) {
                            //刷新列表
                            paren");
                WriteLiteral(@"t.table.reload('testReload', {
                                page: {
                                    curr: 1
                                }
                                , where: {
                                }
                            }, 'data');

                            //关闭当前页
                            var iframeIndex = parent.layer.getFrameIndex(window.name);
                            parent.layer.close(iframeIndex);
                        } else {
                            layer.msg(res.msg);
                        }
                    }
                });


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
