   M S B A M L   `   `   `  ����H  DPayrollSystem, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:PayrollSystem.ModelsPayrollSystem.Models  5      9!clr-namespace:PayrollSystem.ViewsPayrollSystem.Views  5      L    FPayrollSystem.Views.PhilhealthContributions.PhilhealthContributionView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      5models"clr-namespace:PayrollSystem.Models     5      3Views!clr-namespace:PayrollSystem.Views     5      -   5        $   PayrollSystem.Views.BaseWindow   Name$  Window��5       � Title$ Philhealth Contribution��5      $��Segoe UI)�5       � Icon$4 ./PayrollSystem;component/Images/philhealth.png��5	       � 
ResizeMode$ NoResize=�5
       � SizeToContent$ WidthAndHeight=�5       � WindowStartupLocation$ CenterScreen=�5       � DataContext 5      1   +PayrollSystem.Models.PhilhealthContribution  5   
   .��5      � $	��300��6    #  PhilhealthContributionViewColor#���   6   $	��331��6V    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��40 �6   .+�5   
   �� -   5         ��Name$
 Data��5      $��0��5      $��16,16,16,32q�5      .+�5      �� ���	#7FFFFFFF  AttributeLabel#���  5      $��Minimum��5      �� 5      -   5        	 ��Name$	 
txtMinimum��5      $��2q�5      ��5      �� *	Minimum+  DecimalConverter
 �� 	Converter#
 [  �� StringFormat$ {0:N}���� 5!      ���	#7FFFFFFF#���  5"      $��Maximum��5#      �� 5$      -   5        $	 
txtMaximum��5$      $��2q�5%      ��5&      �� *	Maximum+#
 [ $ {0:N}���� 5)      ���	#7FFFFFFF#���  5*      $��Employee Share (EES)��5+      �� 5,      -   5        $	 txtEmployeeShare��5,      $��2q�5-      ��5.      �� *EmployeeShare+#
 [ $ {0:N}���� 51      ���	#7FFFFFFF#���  52      $��Employer Share (ERS)��53      �� 54      -   5        $	 txtEmployerShare��54      $��2q�55      ��56      �� *EmployerShare+#
 [ $ {0:N}���� 59      ���	#7FFFFFFF#���  5:      $��Total��5;      �� 5<      -   5        $	 txtTotal��5<      $��2q�5=      ��5>      �� *Total+#
 [ $ {0:N}��5A      �� 5B   
   $��1��6   ���	#1E000000._�5C      �� -   5        $ Action��5C      $��8q�5D      $��Right=�5E       �� Orientation$ 
Horizontal=�5F      .+�5G      �� -	   5         ��Name$ btnSave��5G      $��75��5H      $��0,0,4,0q�5I      $
��Save��5J      �� 5K      -
   5        $ 	btnCancel��5K      $��75��5L      $��Cancel��5M      5N      5O      5P      5Q      