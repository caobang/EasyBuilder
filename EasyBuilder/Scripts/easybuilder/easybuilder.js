(function ($) {
    var easybuilder = {};
    ///cookie操作
    easybuilder.cookie = {
        expires: 30 ,// cookie 默认将被保存 30 天
        get: function (name) {
            var arr = document.cookie.match(new RegExp("(^| )" + name + "=([^;]*)(;|$)"));
            if (arr != null) return unescape(arr[2]); return null;
        },
        set: function (name, value, day) {
            if (day == null)
                day = this.expires;
            var exp = new Date();
            exp.setTime(exp.getTime() + day * 24 * 3600 * 1000);
            document.cookie = name + "=" + escape(value) + ";expires=" + exp.toGMTString();
        },
        del: function (name) {
            var exp = new Date();
            exp.setTime(exp.getTime() - 1);
            var cval = this.get(name);
            if (cval != null) document.cookie = name + "=" + cval + ";expires=" + exp.toGMTString();
        }
    }
    ///主题
    easybuilder.theme = {
        load: function () {
            var theme = easybuilder.cookie.get("admin_theme");
            this.change(theme, true);
        },
        change: function (name, nosave) {
            if (name == null)
                return;
            var link = $("link[href$='easyui.css']"), href = link.attr("href"), array = href.split("/");
            if (array[array.length - 2] == name)
                return;
            array[array.length - 2] = name;
            var href = array.join("/");
            link.attr("href", href);
            $("iframe").each(function () { $("link[href$='easyui.css']", this.contentWindow.document).attr("href", href) });
            if (nosave)
                return;
            easybuilder.cookie.set("admin_theme", name);
        }
    }

    window.easybuilder = window.eb = easybuilder;


    //初始化
    window.easybuilder.theme.load();


})(jQuery);

