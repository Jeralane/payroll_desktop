   M S B A M L   `   `   `  ����H  DPayrollSystem, Version=2.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:PayrollSystem.UserControlsPayrollSystem.UserControls  5   	   1    +PayrollSystem.Views.Employees.EmployeesList   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   6l(clr-namespace:PayrollSystem.UserControls     5   	     � Title$  Employees List��5   	    � Icon$1 +/PayrollSystem;component/Images/workers.png��5   	      
RootWindow#���   5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5
      � -   5         �Name$ RootGrid��5
        EmployeesListColor#���  5        RootGrid#���  5      .+�5   
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
row_number+57   )     58      -	   5        dataGridTextColumn��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 59   )     StringDataGridTextColumn# �  5;   )   $ 	Issued Id��5<   )    5:   )   �� *issued_id_number+5<   )     5=      $ * 6)   # �  5?   )   $ 	Last Name��5@   )    5>   )   �� *	last_name+5@   )     5A      $ * 6)   # �  5C   )   $ 
First Name��5D   )    5B   )   �� *
first_name+5D   )     5E      $ * 6)   # �  5G   )   $ Middle Name��5H   )    5F   )   �� *middle_name+5H   )   5J      5K      5L      5M      