   M S B A M L   `   `   `  ����R  NCryptoCompareAPIProject, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:CryptoCompareAPIProjectCryptoCompareAPIProject  5      *    $CryptoCompareAPIProject.TopMarketCap   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QScottPlot.WPF, Version=4.1.33.0, Culture=neutral, PublicKeyToken=e53b06131e34a3aaR NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      7local%clr-namespace:CryptoCompareAPIProject     5        N� Title$  TopMarketCap��5      $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $	��300 �6   6+   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	DataGrid2��5         AutoGenerateColumns .     CanUserAddRows .  $��0,10,0,0q�6Y      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Symbol��6J      Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6Z   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� 	 �� Path$	 
FROMSYMBOL�
   ElementStyle
 5      �� 5      .�5      ��  �� Property � �� �� Value$
 Wrap=�6G   5      5        5      $ Price��6E   $ * 6T    6%   �� $	 PRICE�
 5      �� 5      .�5      ��  � ��$
 Wrap=�6G   5      5        5      $ 
24h Volume��6L   $ * 6`    6%   �� $	 VOLUME24HOUR�
 5      �� 5       .�5!      ��  � ��$
 Wrap=�6G   5"      5$        5%      $ 
Market cap��6F   $ * 6Z    6%   �� $	 MKTCAP�
 5&      �� 5'      .�5(      ��  � ��$
 Wrap=�6G   5)      5+        5,      $ Total volume 24h��6N   $ * 6h    6%   �� $	 TOTALVOLUME24H�
 5-      �� 5.      .�5/      ��  � ��$
 Wrap=�6G   50      52      54      55      56      