   M S B A M L   `   `   `  ����  PayrollSystemO    IPayrollSystem.Views.WithholdingTaxDeductions.WithholdingTaxDeductionsList   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$&   Withholding Tax Deduction Matrix��5   	    � Icon$- '/PayrollSystem;component/Images/bir.png��5   	      
RootWindow#���   5   	    � WindowStartupLocation$ CenterScreen=�5   	   .��5	      � -   5         �Name$ RootGrid��5	       % !WithholdingTaxDeductionsListColor#���  5
        RootGrid#���  5      .+�5   
   ]� $��8q�6   .+�5      � -   5        $ Buttons��5      $��26��5      $��Bottom=�5      .+�5      �� -   5         ��Name$ btnAdd��5      $��80��5      $
��Left=�5      $	��Add��5      �� 5      -   5        $ btnEdit��5      $��80��5      $��84,0,0,0q�5      $
��Left=�5      $
��Edit��5      �� 5      -   5        $ 	btnDelete��5      $��80��5      $��	168,0,0,0q�5      $
��Left=�5      $��Delete��5      5      &   System.Windows.Controls.DataGrid  5      -   5          Name$ 	dataGrid1��5      $	��744��5       $��0,0,0,8q�5!         AutoGenerateColumns .  ���	#E5FFFFFF   FrozenColumnCount$ 3��5$         HeadersVisibility$ Column=�5%      	   HorizontalGridLinesBrush
	 �����$
   HorizontalScrollBarVisibility$
 Visible=�5'         
IsReadOnly .    SelectionMode$ Single=�5)         VerticalGridLinesBrush
 �������5+      �� 5,        BorderMediumColor �� Color# �  6&      Columns 5.      0  *System.Windows.Controls.DataGridTextColumn  5/        NumericDataGridTextColumn1  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# �  50   )   ,  &System.Windows.Controls.DataGridColumn   Header$ #��51   )      Binding 5/   )   �� *
row_number+51   )     53         Width5  /System.Windows.Controls.DataGridLengthConverter$	 160 6)     StringDataGridTextColumn# �  56   )   $
 Type��57   )    54   )   �� *payment_type+  PaymentTypeConverter �� 	Converter# [ 57   )     59      $	 100 6)   $ 	Tax Group��5;   )    5:   )   �� *tax_group_id+5;   )     5=      $	 100 6)   # �  5@   )   $ 1 Exempt��5A   )    5>   )   �� *
exemption1+ �� StringFormat$ {0:N2}��5A   )     5C      $	 100 6)   # �  5F   )   $ 
1 Multiply��5G   )    5D   )   �� *percent_multiplier1+$ {0:N2}��5G   )     5I      $	 100 6)   # �  5L   )   $ 	1 Minuend��5M   )    5J   )   �� *basic_pay_minuend1+$ {0:N2}��5M   )     5P      $	 100 6)   # �  5S   )   $ 2 Exempt��5T   )    5Q   )   �� *
exemption2+$ {0:N2}��5T   )     5V      $	 100 6)   # �  5Y   )   $ 
2 Multiply��5Z   )    5W   )   �� *percent_multiplier2+$ {0:N2}��5Z   )     5\      $	 100 6)   # �  5_   )   $ 	2 Minuend��5`   )    5]   )   �� *basic_pay_minuend2+$ {0:N2}��5`   )     5c      $	 100 6)   # �  5f   )   $ 3 Exempt��5g   )    5d   )   �� *
exemption3+$ {0:N2}��5g   )     5i      $	 100 6)   # �  5l   )   $ 
3 Multiply��5m   )    5j   )   �� *percent_multiplier3+$ {0:N2}��5m   )     5o      $	 100 6)   # �  5r   )   $ 	3 Minuend��5s   )    5p   )   �� *basic_pay_minuend3+$ {0:N2}��5s   )     5v      $	 100 6)   # �  5y   )   $ 4 Exempt��5z   )    5w   )   �� *
exemption4+$ {0:N2}��5z   )     5|      $	 100 6)   # �  5   )   $ 
4 Multiply��5�   )    5}   )   �� *percent_multiplier4+$ {0:N2}��5�   )     5�      $	 100 6)   # �  5�   )   $ 	4 Minuend��5�   )    5�   )   �� *basic_pay_minuend4+$ {0:N2}��5�   )     5�      $	 100 6)   # �  5�   )   $ 5 Exempt��5�   )    5�   )   �� *
exemption5+$ {0:N2}��5�   )     5�      $	 100 6)   # �  5�   )   $ 
5 Multiply��5�   )    5�   )   �� *percent_multiplier5+$ {0:N2}��5�   )     5�      $	 100 6)   # �  5�   )   $ 	5 Minuend��5�   )    5�   )   �� *basic_pay_minuend5+$ {0:N2}��5�   )     5�      $	 100 6)   # �  5�   )   $ 6 Exempt��5�   )    5�   )   �� *
exemption6+$ {0:N2}��5�   )     5�      $	 100 6)   # �  5�   )   $ 
6 Multiply��5�   )    5�   )   �� *percent_multiplier6+$ {0:N2}��5�   )     5�      $	 100 6)   # �  5�   )   $ 	6 Minuend��5�   )    5�   )   �� *basic_pay_minuend6+$ {0:N2}��5�   )     5�      $	 100 6)   # �  5�   )   $ 7 Exempt��5�   )    5�   )   �� *
exemption7+$ {0:N2}��5�   )     5�      $	 100 6)   # �  5�   )   $ 
7 Multiply��5�   )    5�   )   �� *percent_multiplier7+$ {0:N2}��5�   )     5�      $	 100 6)   # �  5�   )   $ 	7 Minuend��5�   )    5�   )   �� *basic_pay_minuend7+$ {0:N2}��5�   )     5�      $	 100 6)   # �  5�   )   $ 8 Exempt��5�   )    5�   )   �� *
exemption8+$ {0:N2}��5�   )     5�      $	 100 6)   # �  5�   )   $ 
8 Multiply��5�   )    5�   )   �� *percent_multiplier8+$ {0:N2}��5�   )     5�      $	 100 6)   # �  5�   )   $ 	8 Minuend��5�   )    5�   )   �� *basic_pay_minuend8+$ {0:N2}��5�   )   5�      5�      5�      5�      