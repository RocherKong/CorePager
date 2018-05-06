
``` html
     ___                       ___                           
    / __\  ___   _ __   ___   / _ \  __ _   __ _   ___  _ __ 
   / /    / _ \ | '__| / _ \ / /_)/ / _` | / _` | / _ \| '__|
  / /___ | (_) || |   |  __// ___/ | (_| || (_| ||  __/| |   
  \____/  \___/ |_|    \___|\/      \__,_| \__, | \___||_|   
                                           |___/             
```

## CorePager is a simple and easy-use pager for .Net Razor view.You can use it in any .Net Website that Written in .net framework4.6.2 or .net core.
### How To Use
#### 0x01.Nuget Install
``` powershell
Install-Package CorePager
```
#### 0x02.Fetch Data in controller and Convert To PagedList
``` c#
- PagedList ctor:public PagedList(IEnumerable<T> ToPageItemList, int pageIndex, int pageSize, long totalItemCount)
IPagedList<OrderModel> OrderList = new PagedList<OrderModel>(list, 5, 10, 100); 
//Or you can use for simple convert to PagedList
IPagedList<OrderModel> OrderList = list.ToPagedList<OrderModel>(5, 10, 100);
return View(OrderList);
```
#### 0x03.Add Namespace for view in _ViewImports.cshtml or View web.config
``` c#
@using CorePager
```
Or
``` xml
<system.web.webPages.razor>
    <pages pageBaseType="System.Web.Mvc.WebViewPage">
      <namespaces>
        ...
        <add namespace="CorePager" />
      </namespaces>
    </pages>
  </system.web.webPages.razor>
```

#### 0x04.Add view Model Type in the top of index.cshtml
``` c#
@model IPagedList<OrderModel>
```

#### 0x05.Use CorePager in your page.
``` html
<div class="clearfix">
    <p class="pull-left" style="margin:20px 10px 0;">当前页：<strong>@Model.CurrentPageIndex</strong> /总计：<strong>@Model.TotalItemCount</strong>  条记录</p>
    @Html.Pager(Model, new PagerOptions
    {
        CssClass = "pagination pull-right",

        NoPageHide = true
    })
</div>
```