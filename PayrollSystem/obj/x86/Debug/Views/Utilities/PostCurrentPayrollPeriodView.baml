   M S B A M L   `   `   `  ����H  DPayrollSystem, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:PayrollSystem.ModelsPayrollSystem.Models  5      9!clr-namespace:PayrollSystem.ViewsPayrollSystem.Views  5      @    :PayrollSystem.Views.Utilities.PostCurrentPayrollPeriodView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      5Models"clr-namespace:PayrollSystem.Models     5      3Views!clr-namespace:PayrollSystem.Views     5        � Title$!  Post Current Payroll Period��5      $��Segoe UI)�5       � Icon$0 */PayrollSystem;component/Images/unpin2.png��5       � 
ResizeMode$ NoResize=�5	       � SizeToContent$ WidthAndHeight=�5
       � WindowStartupLocation$ CenterScreen=�5       � DataContext 5      (   "PayrollSystem.Models.PayrollPeriod  5   
   .��5      � $	��332��6    %  !PostCurrentPayrollPeriodViewColor#���   6   $	��166��6X    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��40 �6   .+�5   
   �� -   5         ��Name$
 Data��5      $��0��5      $	��300��5      $��16,16,16,32q�5      .+�5      ��   AttributeLabelLight#���  6   $��Current Payroll Period��6F   �� 5      -   5         ��Name$ textBox1��5      $��0,0,0,8q�5      	 �� 
IsReadOnly	 . ��5      �� *Description+63   �� 5      -   5        
 ��Name$
 chkIsBillingExempted��5      $��Center=�5      $��Posted��5       d� 	IsChecked 5      �� *
IsPosted+5       �� 5!   
   $��1��6   ���	#1E000000._�5"      �� -   5        $ Action��5"      $��8q�5#      $��Right=�5$       �� Orientation$ 
Horizontal=�5%      .+�5&      �� -   5         ��Name$ btnSave��5&      $��75��5'      $��0,0,4,0q�5(      $
��Save��5)      �� 5*      -   5        $ 	btnCancel��5*      $��75��5+      $��Cancel��5,      5-      5.      5/      50      