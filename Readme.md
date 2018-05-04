
``` html
     ___                       ___                           
    / __\  ___   _ __   ___   / _ \  __ _   __ _   ___  _ __ 
   / /    / _ \ | '__| / _ \ / /_)/ / _` | / _` | / _ \| '__|
  / /___ | (_) || |   |  __// ___/ | (_| || (_| ||  __/| |   
  \____/  \___/ |_|    \___|\/      \__,_| \__, | \___||_|   
                                           |___/             
```

## CorePager is a pager for .Net core Mvc.You can use it in core 2.0 website.
### How To Use
#### 1.Fetch Data in controller and Convert To PagedList
``` c#
- PagedList ctor:public PagedList(IEnumerable<T> ToPageItemList, int pageIndex, int pageSize, long totalItemCount)
IPagedList<OrderModel> OrderList = new PagedList<OrderModel>(list, 5, 10, 100);
return View(OrderList);
```
#### 2.Add Namespace for view in _ViewImports.cshtml
``` c#
@using CorePager
```
#### 3.Add view Model Type in the top of index.cshtml
``` c#
@model IPagedList<OrderModel>
```

#### 4.Use CorePager in the page.
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