#pragma checksum "C:\Users\borze\Desktop\SuperMarket\SuperMarketManagment\WebApp\Pages\EditCategoryComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc355862cb1ee65def320a880990595119d302d5"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\borze\Desktop\SuperMarket\SuperMarketManagment\WebApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\borze\Desktop\SuperMarket\SuperMarketManagment\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\borze\Desktop\SuperMarket\SuperMarketManagment\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\borze\Desktop\SuperMarket\SuperMarketManagment\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\borze\Desktop\SuperMarket\SuperMarketManagment\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\borze\Desktop\SuperMarket\SuperMarketManagment\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\borze\Desktop\SuperMarket\SuperMarketManagment\WebApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\borze\Desktop\SuperMarket\SuperMarketManagment\WebApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\borze\Desktop\SuperMarket\SuperMarketManagment\WebApp\_Imports.razor"
using WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\borze\Desktop\SuperMarket\SuperMarketManagment\WebApp\_Imports.razor"
using WebApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\borze\Desktop\SuperMarket\SuperMarketManagment\WebApp\_Imports.razor"
using CoreBuisness;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\borze\Desktop\SuperMarket\SuperMarketManagment\WebApp\_Imports.razor"
using UseCases;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/editcategory/{categoryId}")]
    public partial class EditCategoryComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Edit Category</h3>");
#nullable restore
#line 7 "C:\Users\borze\Desktop\SuperMarket\SuperMarketManagment\WebApp\Pages\EditCategoryComponent.razor"
 if (category != null)
{

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "C:\Users\borze\Desktop\SuperMarket\SuperMarketManagment\WebApp\Pages\EditCategoryComponent.razor"
                     category

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "class", "form-inline");
            __builder.AddAttribute(4, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "C:\Users\borze\Desktop\SuperMarket\SuperMarketManagment\WebApp\Pages\EditCategoryComponent.razor"
                                                                  OnValidSumit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n        ");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "form-group");
                __builder2.AddMarkupContent(12, "<label for=\"name\">\r\n                Name\r\n            </label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "id", "name");
                __builder2.AddAttribute(15, "class", "form-control");
                __builder2.AddAttribute(16, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\borze\Desktop\SuperMarket\SuperMarketManagment\WebApp\Pages\EditCategoryComponent.razor"
                                              category.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => category.Name = __value, category.Name))));
                __builder2.AddAttribute(18, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => category.Name));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n        ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "form-group");
                __builder2.AddMarkupContent(22, "<label for=\"description\">\r\n                Description\r\n            </label>\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "id", "description");
                __builder2.AddAttribute(25, "class", "form-control");
                __builder2.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\borze\Desktop\SuperMarket\SuperMarketManagment\WebApp\Pages\EditCategoryComponent.razor"
                                                     category.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => category.Description = __value, category.Description))));
                __builder2.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => category.Description));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(29, "\r\n        ");
                __builder2.AddMarkupContent(30, "<button type=\"submit\" class=\"btn btn-primary\" style=\"margin:0 10px\">Сохранить</button>\r\n        ");
                __builder2.OpenElement(31, "button");
                __builder2.AddAttribute(32, "type", "button");
                __builder2.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\borze\Desktop\SuperMarket\SuperMarketManagment\WebApp\Pages\EditCategoryComponent.razor"
                                        OnCancel

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "class", "btn btn-primary");
                __builder2.AddMarkupContent(35, "Отмена");
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
#nullable restore
#line 27 "C:\Users\borze\Desktop\SuperMarket\SuperMarketManagment\WebApp\Pages\EditCategoryComponent.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "C:\Users\borze\Desktop\SuperMarket\SuperMarketManagment\WebApp\Pages\EditCategoryComponent.razor"
       
        [Parameter]
        public string CategoryId{ get; set; }

    private Category category;
    protected override void OnInitialized()
    {
        base.OnInitialized();
        category = new Category();
    }
    protected override void OnParametersSet()
    {
        base.OnParametersSet();
        if (int.TryParse(this.CategoryId, out int iCategoryId))
        {
            this.category = GetCategoryByIdUseCase.Execute(iCategoryId);
        }
    }
    private void OnValidSumit()
    {
        EditCategoryUseCase.Execute(category);
        NavigationManager.NavigateTo("/categories");
    }
    private void OnCancel()
    {
        NavigationManager.NavigateTo("/categories");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEditCategoryUseCase EditCategoryUseCase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IGetCategoryByIdUseCase GetCategoryByIdUseCase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAddCategoryUseCase AddCategoryUseCase { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591