# Blazor.JsonHighlight

## 介绍

**Blazor版本的JSON高亮组件（非JS版本）**

## 使用方式（参考Demo）
在`wwwroot/index.html`文件的`Head`中引入：
```html
<link href="https://lib.baomitu.com/font-awesome/5.15.3/css/all.min.css" rel="stylesheet">
```
Index.razor
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
