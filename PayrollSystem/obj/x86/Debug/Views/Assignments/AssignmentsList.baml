   M S B A M L   `   `   `  ����H  DPayrollSystem, Version=2.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:PayrollSystem.UserControlsPayrollSystem.UserControls  5   	   5    /PayrollSystem.Views.Assignments.AssignmentsList   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   6l(clr-namespace:PayrollSystem.UserControls     5   	     � Title$  Assignment List��5   	    � Icon$2 ,/PayrollSystem;component/Images/add_user.png��5   	      
RootWindow#���   5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5
      � -   5         �Name$ 	RootPanel��5
        AssignmentsListColor#���  5        RootGrid#���  5      .+�5   
   ]� $��8q�6   ��. .+�5      � -   5        $ Footer��5      $��26��5      $��Bottom=�5      .+�5      �� -   5         ��Name$ 	btnManage��5      $��80��5      $
��Left=�5      $��Manage��5      �� 5      -   5         ��Name$ CurrentPayrollPeriodPanel��5      $��Right=�5      $��Center=�5       �� Orientation$ 
Horizontal=�5      .+�5      �� $��0,0,8,0q�6      ModuleDescriptionLight#���  5       $��Payroll Period��5       $
��Wrap=�5       �� 5      -   5         ��Name$ tbkCurrentPayrollPeriod��5       $��0q�5       $��Right=�5       $
��Bold"�5        #���  5!       $
��Wrap=�5#       ��5"       �� *Description+5#       5$      5%      � 5&      -   5        $ SearchPanel��5&      $	��Top=�5'      .+�5)      .   (PayrollSystem.UserControls.SearchTextBox  -   5          Name$ txtFilterByKeyword��5)   "   $��Center=�5*   "   	   	LabelText$#	 Search detachment or employee��5+   "   
   
SearchMode$
 Delayed=�5,   "   5-      &   System.Windows.Controls.DataGrid  5.      -   5          Name$ 	dataGrid1��5.      $��0,2,0,6q�5/         AutoGenerateColumns .  ���	#E5FFFFFF   HeadersVisibility$ Column=�52         HorizontalGridLinesBrush
 �����   
IsReadOnly .    SelectionMode$ Single=�55         VerticalGridLinesBrush
 �������57      �� 58        BorderMediumColor �� Color# �  6&      Columns 5:      0  *System.Windows.Controls.DataGridTextColumn  5;        NumericDataGridTextColumn1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# �  5<   )   ,  &System.Windows.Controls.DataGridColumn   Header$ #��5=   )      Binding 5;   )   �� *
row_number+5=   )     5?         Width5  /System.Windows.Controls.DataGridLengthConverter$	 240 6)     StringDataGridTextColumn# �  5A   )   $ Detachment Name��5B   )    5@   )   �� *detachment_name+5B   )     5D      $	 100 6)   # �  5G   )   $ 	Issued ID��5H   )    5E   )   �� *issued_id_number+ �� StringFormat$ {0:N}��5H   )     5J      $	 140 6)   # �  5M   )   $ 	Last Name��5N   )    5K   )   �� *	last_name+$ {0:N0}��5N   )     5P      $	 140 6)   # �  5S   )   $ 
First Name��5T   )    5Q   )   �� *
first_name+$ {0:N}��5T   )     5V      $	 140 6)   # �  5Y   )   $ Middle Name��5Z   )    5W   )   �� *middle_name+$ {0:N}��5Z   )     5\      $ 80 6)   # �  5_   )   $
 Rate��5`   )    5]   )   �� *rate+$ {0:N}��5`   )     5b      $ 80 6)   # �  5e   )   $
 COLA��5f   )    5c   )   �� *cola+$ {0:N}��5f   )     5h      $ 80 6)   # �  5k   )   $ 
Incentives��5l   )    5i   )   �� *
incentives+$ {0:N}��5l   )     5n      $ 80 6)   # �  5q   )   $ 
Adjustment��5r   )    5o   )   �� *
adjustment+$ {0:N}��5r   )   5u      5v      5w      5x      