   M S B A M L   `   `   `  ����H  DPayrollSystem, Version=2.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:PayrollSystem.UserControlsPayrollSystem.UserControls  5   	   /    )PayrollSystem.Views.Payrolls.PayrollsList   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   6l(clr-namespace:PayrollSystem.UserControls     5   	     � Title$  Payrolls List��5   	    � Icon$4 ./PayrollSystem;component/Images/check_book.png��5   	      
RootWindow#���   5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5
      � -   5         �Name$ RootGrid��5
        PayrollsListColor#���  5        RootGrid#���  5      .+�5   
   ]� $��8q�6   ��. .+�5      � -   5        $ 
FormFooter��5      $��26��5      $��Center=�5      $��Bottom=�5      .+�5      �� $
��Left=�6    �� Orientation$ 
Horizontal=�68   .+�5      �� -   5         ��Name$ btnComputePayroll��5      $	��100��5      $��26��5      $��Compute Payroll��5      $
��Bold"�5      �� 5      -   5        $ btnEditSelected��5      $	��100��5      $��26��5      $��2,0,0,0q�5      $��Edit Selected��5      �� 5      -   5        $ btnPreviewPayroll��5      $	��100��5      $��26��5      $��2,0,0,0q�5       $��Preview Payroll��5!      �� 5"      -   5        $ btnPreviewPayslip��5"      $	��100��5#      $��26��5$      $��2,0,0,0q�5%      $��Preview Payslip��5&      5'      �� 5(      -   5         ��Name$ CurrentPayrollPeriodPanel��5(      $��Right=�5)      $��Center=�5*      $ 
Horizontal=�5+      .+�5,      �� $��0,0,8,0q�6      ModuleDescriptionLight#���  5-       $��Payroll Period��5.       $
��Wrap=�5/       �� 50      -   5         ��Name$ tbkCurrentPayrollPeriod��50       $��0q�51       $��Right=�52       $
��Bold"�53       #���  54       $
��Wrap=�56       ��55       �� *Description+56       57      58      � 59      -	   5        $ SearchPanel��59      $	��Top=�6(   .+�5;      .   (PayrollSystem.UserControls.SearchTextBox  -
   5          Name$ txtFilterByKeyword��5;   "   $��Center=�5<   "   	   	LabelText$#	 Search detachment or employee��5=   "   
   
SearchMode$
 Delayed=�5>   "   5?      &   System.Windows.Controls.DataGrid  5@      -   5          Name$ 	dataGrid1��5@      $��0,2,0,8q�5A         AutoGenerateColumns .  ���	#E5FFFFFF   FrozenColumnCount$ 3��5D         HeadersVisibility$ Column=�5E         HorizontalGridLinesBrush
 �����   
IsReadOnly .    SelectionMode$ Single=�5H         VerticalGridLinesBrush
 �������5J      �� 5K        BorderMediumColor �� Color# �  6&      RowStyle 5M      �� 5N       �� 
TargetType)  #System.Windows.Controls.DataGridRow"  6   .�5O      -   5        5P         Columns 5R      0  *System.Windows.Controls.DataGridTextColumn  5S        NumericDataGridTextColumn1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# �  5T   )   ,  &System.Windows.Controls.DataGridColumn   Header$ #��5U   )      Binding 5S   )   �� *
row_number+5U   )     5V         Width5  /System.Windows.Controls.DataGridLengthConverter$	 200 6)     StringDataGridTextColumn# �  5X   )   $ Detachment Name��5Y   )    5W   )   �� *detachment_name+5Y   )     5[      $	 100 6)   # �  5]   )   $ 	Last Name��5^   )    5\   )   �� *	last_name+5^   )     5`      $	 100 6)   # �  5b   )   $ 
First Name��5c   )    5a   )   �� *
first_name+5c   )     5e      $	 100 6)   # �  5g   )   $ Middle Name��5h   )    5f   )   �� *middle_name+5h   )     5j      $
 Auto 6)   # �  5m   )   $ 	Basic Pay��5n   )    5k   )   �� *	basic_pay+ �� StringFormat$ {0:N}��5n   )     5p      $
 Auto 6)   # �  5s   )   $ OT Pay��5t   )    5q   )   �� *overtime_pay+$ {0:N}��5t   )     5v      $
 Auto 6)   # �  5y   )   $ ND Pay��5z   )    5w   )   �� *night_differential_pay+$ {0:N}��5z   )     5|      $ 60 6)   # �  5   )   $ Holiday Pay��5�   )    5}   )   �� *holiday_pay+$ {0:N}��5�   )     5�      $ 60 6)   # �  5�   )   $
 COLA��5�   )    5�   )   �� *
cola_pay+$ {0:N}��5�   )     5�      $ 80 6)   # �  5�   )   $ 
Incentives��5�   )    5�   )   �� *
incentives+$ {0:N}��5�   )     5�      $
 Auto 6)   # �  5�   )   $ Others��5�   )    5�   )   �� *	other_pay+$ {0:N}��5�   )     5�      $
 Auto 6)   # �  5�   )   $ 	Gross Pay��5�   )    5�   )   �� *	gross_pay+$ {0:N}��5�   )     5�      $
 Auto 6)   # �  5�   )   $ Cash Advance��5�   )    5�   )   �� *cash_advance+$ {0:N}��5�   )     5�      $
 Auto 6)   # �  5�   )   $ 	Insurance��5�   )    5�   )   �� *	insurance+$ {0:N}��5�   )     5�      $
 Auto 6)   # �  5�   )   $ 	Cash Bond��5�   )    5�   )   �� *	cash_bond+$ {0:N}��5�   )     5�      $
 Auto 6)   # �  5�   )   $ Pagibig Contribution��5�   )    5�   )   �� *pagibig_contribution_employee+$ {0:N}��5�   )     5�      $
 Auto 6)   # �  5�   )   $ Pagibig Loan��5�   )    5�   )   �� *pagibig_loan+$ {0:N}��5�   )     5�      $
 Auto 6)   # �  5�   )   $ Philhealth Contribution��5�   )    5�   )   �� *" philhealth_contribution_employee+$ {0:N}��5�   )     5�      $
 Auto 6)   # �  5�   )   $ SSS Contribution��5�   )    5�   )   �� *sss_contribution_employee+$ {0:N}��5�   )     5�      $
 Auto 6)   # �  5�   )   $ SSS Loan��5�   )    5�   )   �� *
sss_loan+$ {0:N}��5�   )     5�      $
 Auto 6)   # �  5�   )   $ Tax Withheld��5�   )    5�   )   �� *tax_withheld+$ {0:N}��5�   )     5�      $
 Auto 6)   # �  5�   )   $ Other Deductions��5�   )    5�   )   �� *other_deductions+$ {0:N}��5�   )     5�      $
 Auto 6)   # �  5�   )   $ Total Deductions��5�   )    5�   )   �� *total_deductions+$ {0:N}��5�   )     5�      $
 Auto 6)   # �  5�   )   $ Net Pay��5�   )    5�   )   �� *	net_pay+$ {0:N}��5�   )   5�      5�      5�      5�      