# UniPlistDocumentWrapper

PlistDocument のラッパークラス

## 使用例

```cs
using Kogane;
using UnityEditor;

public static class Example
{
    [MenuItem( "Tools/Hoge" )]
    private static void Hoge()
    {
        using ( var plist = new PlistDocumentWrapper( "iOS/Info.plist" ) )
        {
            plist.SetBundleDevelopmentRegion( true );
        }
    }
}
```
