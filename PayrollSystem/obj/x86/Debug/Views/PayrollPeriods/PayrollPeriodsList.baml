   M S B A M L   `   `   `  ����H  DPayrollSystem, Version=2.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:PayrollSystem.UserControlsPayrollSystem.UserControls  5   	   ;    5PayrollSystem.Views.PayrollPeriods.PayrollPeriodsList   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   6l(clr-namespace:PayrollSystem.UserControls     5   	     � Title$  Payroll Period List��5   	    � Icon$; 5/PayrollSystem;component/Images/tear_off_calendar.png��5   	      
RootWindow#���   5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5
      � -   5         �Name$ RootGrid��5
        PayrollPeriodsListColor#���  5        RootGrid#���  5      .+�5   
   ]� $��8q�6   .+�5      � -   5        $ Buttons��5      $��26��5      $��Bottom=�5      .+�5      �� -   5         ��Name$ btnAdd��5      $��80��5      $
��Left=�5      $	��Add��5      �� 5      -   5        $ btnEdit��5      $��80��5      $��84,0,0,0q�5      $
��Left=�5      $
��Edit��5      �� 5      -   5        $ 	btnDelete��5      $��80��5      $��	168,0,0,0q�5      $
��Left=�5      $��Delete��5      5      � 5       -   5        $ SearchPanel��5       $	��Top=�5!      .+�5#      .   (PayrollSystem.UserControls.SearchTextBox  -   5          Name$ txtFilterByKeyword��5#   "   $��Center=�5$   "      	LabelText$ Search��5%   "      
SearchMode$ Delayed=�5&   "   5'      &   System.Windows.Controls.DataGrid  5(      -   5          Name$ 	dataGrid1��5(      $��0,2,0,6q�5)      	   AutoGenerateColumns	 .  ���	#E5FFFFFF
   HeadersVisibility$
 Column=�5,         HorizontalGridLinesBrush
 �����   
IsReadOnly .    SelectionMode$ Single=�5/         VerticalGridLinesBrush
 �������51      �� 52        BorderMediumColor �� Color# �  6&      Columns 54      0  *System.Windows.Controls.DataGridTextColumn  55        NumericDataGridTextColumn1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# �  56   )   ,  &System.Windows.Controls.DataGridColumn   Header$ #��57   )      Binding 55   )   �� *
row_number+57   )     59         Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 6)     StringDataGridTextColumn# �  5;   )   $ Description��5<   )    5:   )   �� *description+5<   )     5>      $ 70 6)   # �  5A   )   $
 From��5B   )    5?   )   �� *	from_date+ �� StringFormat$ {0:d}��5B   )     5D      $ 70 6)   # �  5G   )   $ To��5H   )    5E   )   �� *	to_date+$ {0:d}��5H   )     5J      $
 Auto 6)   # �  5M   )   $ Month��5N   )    5K   )   �� *
this_month+  MonthConverter �� 	Converter# [ 5N   )     5P      $
 Auto 6)   # �  5R   )   $
 Year��5S   )    5Q   )   �� *	this_year+5S   )     5U      $	 100 6)   # �  5X   )   $ Cutoff��5Y   )    5V   )   �� *	period_id+  PeriodIdConverter# [ 5Y   )     5[      $
 Auto 6)   # �  5]   )   $
 Days��5^   )    5\   )   �� *working_days+5^   )   4  .System.Windows.Controls.DataGridCheckBoxColumn  5`      $
 Auto 6-   $ Posted��5b   -    5a   -   �� *	is_posted+ 5c      �� 5d       �� BasedOn# [B��6$    �� 
TargetType" ��6Q   .�5e   "   ��  �� Property � �� �� Value$ Center=�6H   �� 5f   "    � ��$ Center=�6F   5g      5i        5k      $	 200 6)   # �  5m   )   $ Remarks��5n   )    5l   )   �� *	Remarks+5n   )   5q      5r      5s      5t      