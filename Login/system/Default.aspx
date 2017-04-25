<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="system_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>客户信息管理系统</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
</head>
<body>
    <form id="form1" runat="server">

    <ext:PageManager ID="pm1" runat="server" AutoSizePanelID="rp_Deafult" />
    <ext:RegionPanel ID="rp_Deafult" runat="server">
        <regions>
            <ext:Region ID="Region1" Margins="0 0 0 0" Height="35" ShowBorder="false" ShowHeader="false"
                Position="Top" Layout="Fit" runat="server">
                <Items>
                    <ext:ContentPanel ShowBorder="false" ShowHeader="false" BodyStyle="background-color:#1C3E7E;"
                        runat="server">
                        <table cellpadding="0" cellspacing="0" width="100%">
                        <tr>
                            <td style="line-height: 35px; font-family: 宋体; font-size: 20px; padding-left: 20px; color: #fff; font-weight: bold;">
                                实地地产
                            </td>
                            <td style="text-align:right;color:#ccc;">
                                 <img src="images/main_07_1.gif" id="Image2" onmouseover="MM_swapImage('Image2','','images/main_07.gif',2)"
                                    onmouseout="MM_swapImgRestore()" onclick='openWindow("../login.aspx")' width="72"
                                    height="29" />
                            </td>
                        </tr>
                        </table>
                    </ext:ContentPanel>
                </Items>
            </ext:Region>
            <ext:Region ID="rp_Left" Split="true" CollapseMode="Mini" Width="200px" EnableBackgroundColor="true"
                Margins="0" ShowHeader="true" Title="网站后台管理" Layout="Fit" Position="Left" runat="server">
                <Items>
                    <ext:Tree ID="Tree_Main" runat="server" ShowHeader="false" ShowBorder="false" EnableArrows="true"
                        EnableSingleExpand="true">
                        <Nodes>
                            <ext:TreeNode Text="客户管理" SingleClickExpand="true">
                                <Nodes>
                                    <ext:TreeNode Text="客户列表" NavigateUrl="get_customer.aspx" Expanded="false" Target="_self"
                                        IconUrl="images/class.gif" Leaf="true">
                                    </ext:TreeNode>
                                    
                                </Nodes>
                            </ext:TreeNode>
                              <ext:TreeNode Text="经纪人管理" SingleClickExpand="true">
                                <Nodes>
                                    <ext:TreeNode Text="经纪人列表" NavigateUrl="get_Agent.aspx" Expanded="false" Target="_self"
                                        IconUrl="images/class.gif" Leaf="true">
                                    </ext:TreeNode>
                                    
                                </Nodes>
                            </ext:TreeNode>
                            <ext:TreeNode Text="置业顾问管理" SingleClickExpand="true">
                                <Nodes>
                                    <ext:TreeNode Text="置业顾问列表" NavigateUrl="get_Dynatown.aspx" Expanded="false" Target="_self"
                                        IconUrl="images/class.gif" Leaf="true">
                                    </ext:TreeNode>
                                    
                                </Nodes>
                            </ext:TreeNode>
                        </Nodes>
                    </ext:Tree>
                </Items>
            </ext:Region>
            <ext:Region ID="rp_Center" Margins="0" Layout="Fit" Position="Center" ShowHeader="false">
                <Items>
                    <ext:TabStrip ID="mainTabStrip" EnableTabCloseMenu="true" ShowBorder="false" runat="server">
                        <Tabs>
                            <ext:Tab ID="Tab1" Title="首页" Layout="Fit" IFrameUrl="detial.aspx" Icon="House"  runat="server" EnableIFrame="true">

                                 
                               
                            </ext:Tab>
                           
                        </Tabs>
                    </ext:TabStrip>
                    
                </Items>
               
            </ext:Region>
            
        </regions>
       
    </ext:RegionPanel>
        
    <script type="text/javascript">
        function showwindows(a, b, c) {
            var mainTabStrip = Ext.getCmp('<%= mainTabStrip.ClientID %>');
            mainTabStrip.addTab({
                'id': a,
                'url': b,
                'title': c,
                'closable': true,
                'bodyStyle': 'padding:2px;'
            });
        }
        function MM_preloadImages() { //v3.0
            var d = document; if (d.images) {
                if (!d.MM_p) d.MM_p = new Array();
                var i, j = d.MM_p.length, a = MM_preloadImages.arguments; for (i = 0; i < a.length; i++)
                    if (a[i].indexOf("#") != 0) { d.MM_p[j] = new Image; d.MM_p[j++].src = a[i]; }
            }
        }

        function MM_swapImgRestore() { //v3.0
            var i, x, a = document.MM_sr; for (i = 0; a && i < a.length && (x = a[i]) && x.oSrc; i++) x.src = x.oSrc;
        }

        function MM_findObj(n, d) { //v4.01
            var p, i, x; if (!d) d = document; if ((p = n.indexOf("?")) > 0 && parent.frames.length) {
                d = parent.frames[n.substring(p + 1)].document; n = n.substring(0, p);
            }
            if (!(x = d[n]) && d.all) x = d.all[n]; for (i = 0; !x && i < d.forms.length; i++) x = d.forms[i][n];
            for (i = 0; !x && d.layers && i < d.layers.length; i++) x = MM_findObj(n, d.layers[i].document);
            if (!x && d.getElementById) x = d.getElementById(n); return x;
        }

        function MM_swapImage() { //v3.0
            var i, j = 0, x, a = MM_swapImage.arguments; document.MM_sr = new Array; for (i = 0; i < (a.length - 2); i += 3)
                if ((x = MM_findObj(a[i])) != null) { document.MM_sr[j++] = x; if (!x.oSrc) x.oSrc = x.src; x.src = a[i + 2]; }
        }

        function closeweb() {
            var truthBeTold = window.confirm("是否退出CRM系统");
            if (truthBeTold) {
                window.opener = null;
                window.open("", "_self");
                window.close();
            }
        }
        function openshowModalDialog(src, width, height, scroll) {
            window.showModalDialog(src, "", "location:No;status:No;help:No;dialogWidth:" + width + ";dialogHeight:" + height + ";scroll:" + scroll + ";");
        }
        function openWindow(href) {
            try {
                window.open(href, "_self");
            } catch (e) {

            }
        }
        function onReady() {
            var treeMenu = Ext.getCmp('<%= Tree_Main.ClientID %>');

            // Click expand toolbar button.
            //            });

            // Click collapse toolbar button.


            function addExampleTab(node) {
                var href = node.attributes.href;

                var openNewWindowButton = new Ext.Button({
                    text: 'Open in New Window',
                    type: "button",
                    cls: "x-btn-text-icon",
                    icon: '<%= IconHelper.GetIconUrl(Icon.TabGo) %>',
                    listeners: {
                        click: function(button, e) {
                            window.open(href, "_blank");
                            e.stopEvent();
                        }
                    }
                });

                var refreshButton = new Ext.Button({
                    text: 'Refresh',
                    type: "button",
                    cls: "x-btn-text-icon",
                    icon: '<%= IconHelper.GetIconUrl(Icon.Reload) %>',
                    listeners: {
                        click: function(button, e) {
                            // Note: button.ownerCt is toolbar, button.ownerCt.ownerCt is current active tab.
                            Ext.DomQuery.selectNode('iframe', button.ownerCt.ownerCt.getEl().dom).contentWindow.location.replace(href);
                            e.stopEvent();
                        }
                    }
                });

                // Add a dynamic tab (With toolbar).
                var mainTabStrip = Ext.getCmp('<%= mainTabStrip.ClientID %>');
                var tabID = 'dynamic_added_tab' + node.id.replace('__', '-');
                mainTabStrip.addTab({
                    'id': tabID,
                    'url': href,
                    'title': node.text,
                    'closable': true,
                    'bodyStyle': 'padding:0px;',
                    'iconCls': 'icon_' + href.replace(/[^.]+\./, '')
                        , 'tbar': new Ext.Toolbar({
                        //                       items: ['->', sourcecodeButton, '-', refreshButton, '-', openNewWindowButton]
                    })
                });
            }

            // Click the tree node.
            treeMenu.on('click', function(node, event) {
                if (node.isLeaf()) {
                    var href = node.attributes.href;
                    // Modify the location of current url.
                    window.location.href = '#' + href;

                    addExampleTab(node);

                    // Don't response to this tree node's default behavior. 
                    event.stopEvent();
                }
            });


            (function pageFirstLoad() {
                var currentHash = window.location.hash.substr(1);
                var level1Nodes = treeMenu.getRootNode().childNodes;
                for (var i = 0; i < level1Nodes.length; i++) {
                    var level2Nodes = level1Nodes[i].childNodes;
                    for (var j = 0; j < level2Nodes.length; j++) {
                        var currentNode = level2Nodes[j];
                        if (currentNode.attributes.href === currentHash) {
                            level1Nodes[i].expand();
                            // We must retrieve this node again, because currentNode doesn't has parentNode property.
                            var foundNode = treeMenu.getNodeById(currentNode.id);
                            foundNode.select();
                            addExampleTab(foundNode);
                            return;
                        }
                    }
                }
            })();

        }

    </script>

    </form>
</body>
</html>
