/*
http://www.cgsoso.com/forum-211-1.html

CG搜搜 Unity3d 每日Unity3d插件免费更新 更有VIP资源！

CGSOSO 主打游戏开发，影视设计等CG资源素材。

插件如若商用，请务必官网购买！

daily assets update for try.

U should buy the asset from home store if u use it in your project!
*/

namespace Facebook.Unity.Example
{
    internal class AppLinks : MenuBase
    {
        protected override void GetGui()
        {
            if (this.Button("Get App Link"))
            {
                FB.GetAppLink(this.HandleResult);
            }

            if (Constants.IsMobile && this.Button("Fetch Deferred App Link"))
            {
                FB.Mobile.FetchDeferredAppLinkData(this.HandleResult);
            }
        }
    }
}
