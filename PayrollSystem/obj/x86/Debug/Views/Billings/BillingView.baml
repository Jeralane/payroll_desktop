   M S B A M L   `   `   `  ����H  DPayrollSystem, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:PayrollSystem.ModelsPayrollSystem.Models  5   	   .    (PayrollSystem.Views.Billings.BillingView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   6payroll"clr-namespace:PayrollSystem.Models     5   	   -   5          �Name$  Window��5   	    � Title$ Billing Details��5   	      BillingModuleColor#���   5   	   $��Segoe UI)�5   	    � 
ResizeMode$ NoResize=�5	   	    � SizeToContent$ WidthAndHeight=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � DataContext 5      "   PayrollSystem.Models.Billing  5   
   .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��40 �6   .+�5   
   �� -   5         ��Name$
 Data��5      $��0��5      $	��300��5      $��
16,16,16,8q�5      .+�5      ��   AttributeLabelLight#���  6   $��
Agency Fee��6F   �� 5      -   5         ��Name$ 
txtMinimum��5      $��23��5      $��0,0,0,8q�5      $��2q�5      ��5      �� *	AgencyFee+  DecimalConverter	 �� 	Converter#	 [ 
 �� StringFormat$
 {0:N}���� 5       #���  6   $��Agency Vat Fee��6F   �� 5!      -   5        $ 
txtMaximum��5!      $��23��5"      $��0,0,0,8q�5#      $��2q�5$      ��5%      �� *AgencyVatFee+#	 [ $
 {0:N}���� 5(      #���  6   $��Agency Fee Total��6F   �� 5)      -   5        $ txtEmployeeShare��5)      $��23��5*      $��0,0,0,8q�5+      $��2q�5,      ��5-      �� *AgencyFeeTotal+#	 [ $
 {0:N}���� 50      #���  6   $��Billing Number��6F   �� 51      -   5        $ txtEmployerShare��51      $��23��52      $��0,0,0,8q�53      $��2q�54      ��55      �� *BillingNumber+�� 56      #���  6   $��Billing Type��6F   �� 57      -   5        $ txtTotal��57      $��23��58      $��0,0,0,8q�59      $��2q�5:      ��5;      �� *BillingType+$
 {0:N}��5=      �� 5>   
   $��1��6   ���	#1E0000006   �� 5?   
   -   5        $ Action��5?      $��1��5@      $��8q�5A      $��Right=�5B       �� Orientation$ 
Horizontal=�5C      .+�5D      �� -	   5         ��Name$ btnSave��5D      $��75��5E      $��23��5F      $��0,0,4,0q�5G      $
��Save��5H      �� 5I      -
   5        $ 	btnCancel��5I      $��75��5J      $��23��5K      $��Cancel��5L      5M      5N      5O      