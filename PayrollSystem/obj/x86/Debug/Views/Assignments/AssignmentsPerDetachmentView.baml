   M S B A M L   `   `   `  ����H  DPayrollSystem, Version=2.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:PayrollSystem.UserControlsPayrollSystem.UserControls  5   	   B    <PayrollSystem.Views.Assignments.AssignmentsPerDetachmentView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   OPayrollSystem_UserControls(clr-namespace:PayrollSystem.UserControls     5   	     � Title$   Assignments Per Detachment��5   	    � Icon$2 ,/PayrollSystem;component/Images/add_user.png��5   	      
RootWindow#���   5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5
      �  % !AssignmentsPerDetachmentViewColor#���  6     RootGrid#��[ 6L    � RowDefinitions 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   � ���	#1E000000 � ColumnDefinitions 5      �� 5      $	��.7* �6#   �� 5      $	��.3* �6#   .+�5      �� $��1��6   $��8q�5       �� Orientation$ 
Horizontal=�5      .+�5      �� -   5         ��Name$ CurrentPayrollPeriodPanel��5      $��4,4,4,4q�5        ButtonElementStyle#���  5      .+�5      �� $��26��6!   $��26��6,   .+�5      �� $A��;/PayrollSystem;component/Images/tear_off_calendar_light.png��6    5      �� 5      $��4,0,0,0q�6!   $ Vertical=�62   .+�5       ��   ModuleTitleLight#���  6$   ��6O   �� *Description+�� 5!        ModuleDescriptionLight#���  6$   $��Current Payroll Period��6U   5"      5#      5$      �� 5%      -   5        $ SelectedDetachmentPanel��5%      $��8q�5&      $ 
Horizontal=�5'      .+�5(      �� $��4,4,4,4q�6   #���  6.   .+�5)      �� $��26��6!   $��26��6,   .+�5*      �� -   5         ��Name$ imgDetachment��5*        � Cursor$
 Hand��5+       $5��//PayrollSystem;component/Images/hotel_light.png��5,       5-      �� 5.      $��4,0,0,0q�6!   $ Vertical=�62   .+�5/      �� #���  6$   ��6O   �� *Name+�� 50      #���  6$   ��6U   �� *	Address+51      52      53      54      � 55   
   -   5        	 �Name$	 SearchPanel��55      $��1��56      $��8,8,8,0q�57      $��Bottom=�58      .+�5:      .   (PayrollSystem.UserControls.SearchTextBox  -   5        
  Name$
 txtFilterByKeyword��5:   7      	LabelText$ Search employee��5;   7      
SearchMode$ Delayed=�5<   7   5=      &   System.Windows.Controls.DataGrid  5>   
   -   5          Name$ 	dataGrid1��5>      $��2��5?      $��8,2,8,8q�5@         AutoGenerateColumns .     HeadersVisibility$ Column=�5B         HorizontalGridLinesBrush
 �����   
IsReadOnly .    SelectionMode$ Single=�5E         VerticalGridLinesBrush
 �������5G      �� 5H        BorderMediumColor �� Color# �  6"      Columns 5J      0  *System.Windows.Controls.DataGridTextColumn  5K        NumericDataGridTextColumn1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# �  5L   %   ,  &System.Windows.Controls.DataGridColumn   Header$ #��5M   %      Binding 5K   %   �� *
row_number+5M   %     5O         Width5  /System.Windows.Controls.DataGridLengthConverter$ 90 6%     StringDataGridTextColumn# �  5R   %   $ 	Issued ID��5S   %    5P   %   �� *issued_id_number+ �� StringFormat$ {0:N}��5S   %     5U      $	 120 6%   # �  5X   %   $ 	Last Name��5Y   %    5V   %   �� *	last_name+$ {0:N0}��5Y   %     5[      $	 120 6%   # �  5^   %   $ 
First Name��5_   %    5\   %   �� *
first_name+$ {0:N}��5_   %     5a      $	 120 6%   # �  5d   %   $ Middle Name��5e   %    5b   %   �� *middle_name+$ {0:N}��5e   %     5g      $ 70 6%   # �  5j   %   $
 Rate��5k   %    5h   %   �� *rate+$ {0:N}��5k   %     5m      $ 70 6%   # �  5p   %   $
 COLA��5q   %    5n   %   �� *cola+$ {0:N}��5q   %     5s      $ 70 6%   # �  5v   %   $ 
Incentives��5w   %    5t   %   �� *
incentives+$ {0:N}��5w   %     5y      $ 80 6%   # �  5|   %   $ 
Adjustment��5}   %    5z   %   �� *
adjustment+$ {0:N}��5}   %   5�      � 5�   
   $��3��6   $��26��5�      $��8,0,8,8q�5�      $��Bottom=�5�      .+�5�      �� -   5         ��Name$ btnAdd��5�      $��80��5�      $
��Left=�5�      $	��Add��5�      �� 5�      -   5        $ btnEdit��5�      $��80��5�      $��84,0,0,0q�5�      $
��Left=�5�      $
��Edit��5�      �� 5�      -	   5        $ 	btnDelete��5�      $��80��5�      $��	168,0,0,0q�5�      $
��Left=�5�      $��Delete��5�      5�      5�      5�      