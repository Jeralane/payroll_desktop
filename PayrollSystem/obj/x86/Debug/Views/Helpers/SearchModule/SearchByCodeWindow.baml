   M S B A M L   `   `   `  ����  PayrollSystemA    ;PayrollSystem.Views.Helpers.SearchModule.SearchByCodeWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � SizeToContent$  WidthAndHeight=�5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5      � $��5q�6   .+�5	   
   �� $	��320��6   $��20,60,20,20q�5
       �� Orientation$ Vertical=�5      .+�5      �� $ Vertical=�6   .+�5      �  � ColumnDefinitions 5      �� 5      $
��Auto �6+   �� 5      �� 5      $
��Auto �6+   .+�5      �� -   5         ��Name$ 
lblKeyword��5      $
��Left=�5      $��Keyword��5      
�������5      �� 5      -   5         ��Name$ 
txtKeyword��5      $��1��5      $��8,0,2,0q�5      $��Center=�5         RoundedTextBox#���   5       �� TextWrapping$
 Wrap=�5      �� 5      -   5         ��Name$ SelectButton��5      $��2��5      $��32��5       ���	#FFFFFFFF  
ToolButton#���  5#      .��5$      �� $ 
Horizontal=�6%   .+�5%      �� $��4q�6$   $1��+/SCCO.WPF.MVC.CS;component/Images/Valid.png��5&   $   $
��Fill=�5'   $   5(      5)      5*      5+      &   System.Windows.Controls.DataGrid  5,      -   5          Name$ grdList��5,      $	��400��5-      $��0,4,0,0q�5.      $��Center=�5/      	   AlternatingRowBackground	 �	#33A6CAF0
   AutoGenerateColumns
 .  
����������	#33808080   CanUserAddRows .     CanUserDeleteRows .     ColumnHeaderHeight$ 25Q�56      $��13(�57         HeadersVisibility$ Column=�58         HorizontalGridLinesBrush# � ��59      $   HorizontalScrollBarVisibility$ Disabled=�5:         
IsReadOnly .    	RowHeight$ 24Q�5>         SelectionMode$ Single=�5@         VerticalGridLinesBrush# � ��5A      ��5<      �� *SearchItems+ �� SelectedItem 5?      �� *SelectedItem+   Columns 5B      0  *System.Windows.Controls.DataGridTextColumn  5C      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$
 0.3* 6)      Header$  Code ��5E   )   1  +System.Windows.Controls.DataGridBoundColumn   Binding 5D   )   �� *
ItemCode+5E   )     5F      $ * 6)   $  Name ��5H   )    5G   )   �� *
ItemName+5H   )   5J      5L      5N      5O      