   M S B A M L   `   `   `  ����H  DPayrollSystem, Version=2.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:PayrollSystem.UserControlsPayrollSystem.UserControls  5   	   5    /PayrollSystem.Views.Detachments.DetachmentsList   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   6l(clr-namespace:PayrollSystem.UserControls     5   	     � Title$  Detachment List��5   	    � Icon$/ )/PayrollSystem;component/Images/hotel.png��5   	      
RootWindow#���   5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5
      � -   5         �Name$ RootGrid��5
        DetachmentsListColor#���  5        RootGrid#���  5      .+�5   
   ]� $��8q�6   .+�5      � -   5        $ SearchPanel��5      $	��Top=�5      .+�5      .   (PayrollSystem.UserControls.SearchTextBox  -   5          Name$ txtFilterByKeyword��5   "   $��Center=�5   "      	LabelText$* $Search detachment by name or address��5   "      
SearchMode$ Delayed=�5   "   5      � 5      -   5        $ Buttons��5      $��26��5      $��Bottom=�5      .+�5      �� -   5         ��Name$ btnAdd��5      $��80��5      $
��Left=�5      $	��Add��5      �� 5      -   5        $ btnEdit��5      $��80��5      $��84,0,0,0q�5      $
��Left=�5       $
��Edit��5!      �� 5"      -   5        $ 	btnDelete��5"      $��80��5#      $��	168,0,0,0q�5$      $
��Left=�5%      $��Delete��5&      5'      &   System.Windows.Controls.DataGrid  5(      -   5          Name$ 	dataGrid1��5(      $��0,2,0,6q�5)      	   AutoGenerateColumns	 .  ���	#E5FFFFFF
   HeadersVisibility$
 Column=�5,         HorizontalGridLinesBrush
 �����   
IsReadOnly .    SelectionMode$ Single=�5/         VerticalGridLinesBrush
 �������51      �� 52        BorderMediumColor �� Color# �  6&      Columns 54      0  *System.Windows.Controls.DataGridTextColumn  55        NumericDataGridTextColumn1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# �  56   )   ,  &System.Windows.Controls.DataGridColumn   Header$ #��57   )      Binding 55   )   �� *
row_number+57   )     59         Width5  /System.Windows.Controls.DataGridLengthConverter$	 240 6)     StringDataGridTextColumn# �  5;   )   $ Detachment Name��5<   )    5:   )   �� *name+5<   )     5>      $
 Auto 6)   # �  5A   )   $ 	Hours/Day��5B   )    5?   )   �� *hours_per_day+ �� StringFormat$ {0:N}��5B   )     5D      $
 Auto 6)   # �  5G   )   $ Guards��5H   )    5E   )   �� *number_of_guards+$ {0:N0}��5H   )     5J      $ 80 6)   # �  5M   )   $ Contract��5N   )    5K   )   �� *monthly_contract_amount+$ {0:N}��5N   )     5P      $ 80 6)   # �  5S   )   $ 	Allowance��5T   )    5Q   )   �� *monthly_allowance+$ {0:N}��5T   )     5V      # �  5X   )   $ Monthly Rate��5Y   )    5V   )   �� *monthly_rate+$ {0:N}��5Y   )     5[      $ 80 6)   # �  5^   )   $ 
Daily Rate��5_   )    5\   )   �� *
daily_rate+$ {0:N}��5_   )     5a      $ 80 6)   # �  5d   )   $
 COLA��5e   )    5b   )   �� *cola+$ {0:N}��5e   )     5g      $ 80 6)   # �  5j   )   $ ND Rate��5k   )    5h   )   �� *night_differential_rate+$ {0:N}��5k   )     5m      $ 80 6)   # �  5p   )   $ 
Adjustment��5q   )    5n   )   �� *
adjustment+$ {0:N}��5q   )     5s      $
 Auto 6)   # �  5u   )   $ Address��5v   )    5t   )   �� *	address+5v   )     5x      $
 Auto 6)   # �  5z   )   $ Remarks��5{   )    5y   )   �� *	remarks+5{   )   5~      5      5�      5�      