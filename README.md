# MySectionClip
A simple clipboard processing tool born because ditto can't meet the needs   
由于Ditto不能满足需求诞生的一个简单剪贴板处理工具   
#### v1.3更新 
修正了打开软件就会获取剪贴板内容并处理的bug
修正了有时候ctrl+x后剪贴板内容不能被完全清空的bug
#### v1.2更新   
+增加了透明度控制   
+增加了更多过滤器规则  

#### 使用说明v1.2   

![图片.png](https://upload-images.jianshu.io/upload_images/17488192-27a7688d671370b9.png?imageMogr2/auto-orient/strip%7CimageView2/2/w/1240)


1 打开该软件   
2 在一组在不同位置的,你需要复制的信息上ctrl+c  
3 该软件会使用相应过滤器规则过滤该组信息中的每个信息(默认为把每个信息中的多个相连\n,\r换行符转换为一个空格)并输出在富文本窗口上 (每个信息间额外输出两个换行符)  
4 您可以随意编辑富文本窗口中的信息,但注意不要使用ctrl+c   
5 点击"复制文本"按钮或ctrl+x,清空当前富文本窗口并保存信息到剪贴板里   
6 在目标区域ctrl+v 来方便的复制整组信息而不需要你手动转换格式(尤其是对每段信息替换其中的换行符)  





#### 需求      
由于最强悍的剪贴板管理软件ditto不能满足需求,所以自己开发一个小生产力工具   
已知在win10的任意平台上有如下一段文字    
```
1111111111111111111111111111111111111
1111111111111111111111111111111111111
1111111111111111111111111111111111111
这是一段有效信息:Ditto中可以保留大量（取决于数据库容量）的历史记录。如果想搜索某条记录，只须在主界面的搜索框中输入文字，过滤后的结果会实时展现出来。
说明：
– 实时过滤的方式，比传统的“搜索词→回车→搜索结果列表”更为易用。

1111111111111111111111111111111111111
1111111111111111111111111111111111111
1111111111111111111111111111111111111
1111111111111111111111111111111111111
这是一段有效信息:Ditto允许合并粘贴，就是把多条记录，一次性粘贴到目标窗口。在收集资料时，这点尤其有用。
使用方法：弹出窗口中，按住Shift或Ctrl再点击鼠标左键。
1111111111111111111111111111111111111
1111111111111111111111111111111111111
1111111111111111111111111111111111111
1111111111111111111111111111111111111
这是一段有效信息:
经常有一些内容需要重复使用。比如，电话号码、邮箱、公司地址…… 。这些信息可以通过输入法实现，也可以用剪贴板工具实现。

早期Ditto 有一项非常强大的功能——命名粘贴（Named Paste）。
1111111111111111111111111111111111111
1111111111111111111111111111111111111
```
要求用最快的时间和最小的人工操作把所有有效信息粘贴到word中并保留这样一种格式:    
1只保留文本信息    
2每段有效信息中不应该有换行符,任何换行符都应该重新映射为一个空格(连着的n个换行符只能重新映射为一个空格)    
3每段有效信息间有两个换行符确保段间空一行    
它在word中的形式应该为:    
```
这是一段有效信息:Ditto中可以保留大量（取决于数据库容量）的历史记录。如果想搜索某条记录，只须在主界面的搜索框中输入文字，过滤后的结果会实时展现出来。说明：– 实时过滤的方式，比传统的“搜索词→回车→搜索结果列表”更为易用。

这是一段有效信息:Ditto允许合并粘贴，就是把多条记录，一次性粘贴到目标窗口。在收集资料时，这点尤其有用。使用方法：弹出窗口中，按住Shift或Ctrl再点击鼠标左键。

这是一段有效信息:经常有一些内容需要重复使用。比如，电话号码、邮箱、公司地址…… 。这些信息可以通过输入法实现，也可以用剪贴板工具实现。早期Ditto 有一项非常强大的功能——命名粘贴（Named Paste）。
```
#### 参考   
主要的几个参考思路    
关于C#监视剪贴板信息 https://blog.csdn.net/imxiangzi/article/details/81585080    
C# 操作剪贴板 https://www.cnblogs.com/guogangj/p/7465951.html    
https://blog.csdn.net/jsjyyjs07/article/details/46917985    
Clip类官方文档    
https://docs.microsoft.com/en-us/dotnet/api/?view=netframework-4.8&term=Clipboard    
C# textbox灰色的提示文字    
https://blog.csdn.net/program_thinker/article/details/42462521    
https://q.cnblogs.com/q/68107/    
C#焦点配置    
https://blog.csdn.net/ou832339/article/details/39122395    
C#关于textbox的选中    
https://blog.csdn.net/keenweiwei/article/details/8861690    
C#的字符串替换问题    
https://bbs.csdn.net/topics/390331372    
C#正则表达式Regex类https://www.cnblogs.com/viviancc/p/3448272.html    
窗口最前显示    
https://www.cnblogs.com/moonlight-zjb/p/3645157.html    
https://zhidao.baidu.com/question/409997761.html    
https://blog.csdn.net/Sayesan/article/details/79669332    
https://my.oschina.net/Tsybius2014/blog/1531971    
c# 获取当前活动窗口句柄    
https://blog.csdn.net/pangwenquan5/article/details/40317773    
注意在当前form下使用top直接用this.就行    

C#快捷键设置    
https://blog.csdn.net/wyh0318/article/details/13504981    
https://blog.csdn.net/u013457167/article/details/42479049    
https://blog.csdn.net/cuoban/article/details/50750609    

注意一定要把相应函数注册在form的KeyDown事件上和设置KeyPreview=true;    
还有一个问题是如何注册全局热键,要求包括:    
1 注册ctrl+q等功能热键    
2 注册ctrl+c,ctrl+v而且要确保把剪贴板顶掉    
https://blog.csdn.net/zxj19951029/article/details/40236053    
C#FormClosed 事件的使用    
https://www.cnblogs.com/xuekai-to-sharp/p/3511982.html    
注意由于关闭事件的特殊性一定不要使用常规EventArgs而要使用    
FormClosedEventArgs e 或FormClosingEventArgs e    
![图片.png](https://upload-images.jianshu.io/upload_images/17488192-50769b3ae24588fa.png?imageMogr2/auto-orient/strip%7CimageView2/2/w/1240)    

#### 问题1    
问题:如何使用本程序操纵剪贴板:比如ctrl+v同时完成了复制当前内容到剪贴板和复制剪贴板内容到其他平台(剪贴板本身功能)?    
https://blog.csdn.net/u012543266/article/details/15506575    
https://www.jianshu.com/p/b60b77fcb2a3    
#### 问题2    
原本好用的换行符映射/过滤器在剪贴板中失灵    
注意剪贴板上的换行符有一部分未能替换     
```
//原有文本
楼主定义的这些窗体名字，太......
估计楼主问的还是窗体间传值的问题。
给你个例子参考
```

```
//得到的文本
楼主定义的这些窗体名字，太......
 估计楼主问的还是窗体间传值的问题。
 给你个例子参考

楼主定义的这些窗体名字，太......
  估计楼主问的还是窗体间传值的问题。
  给你个例子参考
```
如何分析win 剪贴板中的特殊换行符    
注意:文件操作的一个细节 - 换行符"\n"和回车符"\r"    
https://blog.csdn.net/xtydtc/article/details/53165044    
```
//修改后的换行符处理函数为:
        private string CharacterFilteringRulesShell(string s)//用于对复制得到内容中换行符的处理
        {
            StringBuilder sb = new StringBuilder(s);
            for (int i = 0; i < sb.Length; i++) if (sb[i].Equals('\r')) sb[i] = '\n';//注意win下的特殊换行符
            string s1 = sb.ToString();
            if (defaultReplace.Checked==false) return CharacterFilteringRules(s1, "\n", " ");
            else return CharacterFilteringRules(s1, "\n", "\n");
        }
```


#### 问题3    
如何刷新窗体    
https://blog.csdn.net/a17601634191a/article/details/90228834    
####问题4    
全局热键的最终参考       
https://www.cnblogs.com/bomo/archive/2012/12/09/2809981.html    
