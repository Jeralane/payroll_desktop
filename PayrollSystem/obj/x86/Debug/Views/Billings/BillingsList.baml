   M S B A M L   `   `   `  ����H  DPayrollSystem, Version=2.0.0.0, Culture=neutral, PublicKeyToken=nullK*clr-namespace:PayrollSystem.Views.BillingsPayrollSystem.Views.Billings  5   	   /    )PayrollSystem.Views.Billings.BillingsList   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   <local*clr-namespace:PayrollSystem.Views.Billings     5   	     � Title$  Billing List��5   	      BillingsListColor#���   5   	   $��Segoe UI)�5   	    � 
ResizeMode$ NoResize=�5   	    � SizeToContent$ WidthAndHeight=�5	   	    � WindowStartupLocation$ CenterScreen=�5
   	    � DataContext 5      4  .PayrollSystem.Views.Billings.BillingsViewModel  5   
   .��5      � $	��760��6   $	��570��6    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   � ���	#1E000000.+�5      �� $��36��6   $��8,12,0,0q�5      $
��Left=�5       �� Orientation$ Vertical=�5      .+�5      �� $:��4/PayrollSystem;component/Images/active_directory.png��6   $
��None=�6V   5      �� 5      $��48,8,8,8q�6   $ Vertical=�6+   .+�5      �� $��13.333(�6   $
��Bold"�5         ModuleTitle#���  5!      $��Billing List��5"      $��WrapWithOverflow=�5#      �� 5$        ModuleDescription#���  6   $#��Display list of all billings.��5%      $��WrapWithOverflow=�5&      5'      5(      � 5)   
   $��1��6   $��26��5*      $��8,12,8,0q�5+      $��Bottom=�5,       � ColumnDefinitions 5-      �� 5.      $
��Auto �6#   �� 5/      $��* �6#   �� 50      $��80 �6#   .+�52      �� $��Center=�6     CaptionColor#���  53      $��Filter by keyword��54      �� 55      -   5         ��Name$ txtFilterByKeyword��55      $��1��56      $	��6,0q�57      $��Center=�58      $��2q�59      �� 5:      -   5        	 ��Name$	 
btnRefresh��5:      $��2��5;      $��Refresh��5<      5=      &   System.Windows.Controls.DataGrid  5>   
   -   5        
  Name$
 	dataGrid1��5>      $��2��5?      $��8q�5@         AutoGenerateColumns .     HeadersVisibility$ Column=�5B         HorizontalGridLinesBrush
 �����   
IsReadOnly .    SelectionMode$ Single=�5G         VerticalGridLinesBrush
 �������5E      �� *
Collection+ �� SelectedItem 5F      �� *SelectedItem+��5I      �� 5J        BorderMediumColor �� Color# �  6"      Columns 5L      0  *System.Windows.Controls.DataGridTextColumn  5M      ,  &System.Windows.Controls.DataGridColumn   Header$ #��6D   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *
row_number+6D     5N         Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6%     NumericDataGridTextColumn   ElementStyle# �  5Q   %   $ Billing Number��5R   %    5O   %   �� *BillingNumber+ �� StringFormat$ {0:N}��5R   %     5S      $ * 6%   # �  5V   %   $ Billing Type��5W   %    5T   %   �� *BillingType+$ {0:N}��5W   %     5X      $ * 6%   # �  5[   %   $ Employee Share��5\   %    5Y   %   �� *EmployeeShare+$ {0:N}��5\   %     5]      $ * 6%   # �  5`   %   $ Employer Share��5a   %    5^   %   �� *EmployerShare+$ {0:N}��5a   %     5b      $ * 6%   # �  5e   %   $ Total��5f   %    5c   %   �� *Total+$ {0:N}��5f   %   5h      � 5i   
   $��3��6   $��26��5j      $��8,0,8,8q�5k      $��Bottom=�5l      .+�5m      �� -   5        $	 btnAdd��5m      $��80��5n      $
��Left=�5o      $	��Add��5p      �� 5q      -   5        $	 btnEdit��5q      $��80��5r      $��84,0,0,0q�5s      $
��Left=�5t      $
��Edit��5u      �� 5v      -   5        $	 	btnDelete��5v      $��80��5w      $��	168,0,0,0q�5x      $
��Left=�5y      $��Delete��5z      5{      5|      5}      