# Blazor.JsonHighlight

## 介绍

**Blazor版本的JSON高亮组件（非JS版本）**

## 使用方式
1. 创建Blazor项目。
2. 在NuGet中安装包`Blazor.JsonHighlight` [![NuGet](https://img.shields.io/nuget/v/Blazor.JsonHighlight.svg?style=flat-square&label=nuget)](https://www.nuget.org/packages/Blazor.JsonHighlight/) ![downloads](https://img.shields.io/nuget/dt/Blazor.JsonHighlight.svg)。
3. 在`wwwroot/index.html`文件的`Head`中引入：
```html
<link href="https://lib.baomitu.com/font-awesome/5.15.3/css/all.min.css" rel="stylesheet">
<link href="_content/Blazor.JsonHighlight/Blazor.JsonHighlight.bundle.scp.css" rel="stylesheet">
```
4. 在页面中使用组件（可参考Demo项目）。
```html
<div>
    <JsonHighlight Element="element"></JsonHighlight>
</div>

@code{
    private JsonElement element;

    protected override async Task OnInitializedAsync()
    {
        string json = await Http.GetStringAsync("sample-data/news.json");
        var doc = JsonDocument.Parse(json);
        element = doc.RootElement;
    }
}
```
