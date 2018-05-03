CorePager
## CorePager is a pager for .Net core Mvc.You can use it in core 2.0 website.
### How To Use
#### 1.Fetch Data in controller and Convert To PagedList
``` c#
- PagedList ctor:public PagedList(IEnumerable<T> ToPageItemList, int pageIndex, int pageSize, long totalItemCount)
IPagedList<OrderModel> OrderList = new PagedList<OrderModel>(list, 5, 14, 100);
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
``` c#
@Html.Pager(Model, new PagerOptions
{
    CssClass = "pagination pull-right",
    Id = "pager",
    NoPageHide = false
})
```