   M S B A M L   `   `   `  ����H  DPayrollSystem, Version=2.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:PayrollSystem.Views.EmployersPayrollSystem.Views.Employers  5   	   0    *PayrollSystem.Views.Employers.EmployerView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   =local+clr-namespace:PayrollSystem.Views.Employers     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -   5          �Name$  window��5   	    � Title$ Employer��5   	   $��Segoe UI)�5	   	    � Icon$6 0/PayrollSystem;component/Images/organization.png��5
   	    � 
ResizeMode$ NoResize=�5   	    � SizeToContent$ WidthAndHeight=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � DataContext 5      5  /PayrollSystem.Views.Employers.EmployerViewModel  5   
   .��5      � $	��400��6   $	��510��6    � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $��40 �6   .+�5   
   �� $��8q�6   .��5      �� -   5         ��Name$
 Data��5      .+�5      ��    PropertyLabel#���   6   $��Employer Name��6D   �� 5      $��0,0,0,8q�6   $��2q�5      ��5      �� *CurrentEmployer.Name+�� 5      #���   6   $��Branch��6D   �� 5      $��0,0,0,8q�6   $��2q�5       ��5!      �� *CurrentEmployer.Branch+�� 5"      #���   6   $��Address��6D   �� 5#      $��0,0,0,8q�6   	 �� 
IsReadOnly	 . $��2q�5%      ��5&      �� *AddressDetails.MailingAddress+�� 5(      #���   6   $��Phone Number��6D   �� 5)      $��0,0,0,8q�6   $��2q�5*      ��5+      �� *CurrentEmployer.PhoneNumber+�� 5-      #���   6   $��
Fax Number��6D   �� 5.      $��0,0,0,8q�6   $��2q�5/      ��50      �� *CurrentEmployer.FaxNumber+�� 52      #���   6   $��Mobile Number��6D   �� 53      $��0,0,0,8q�6   $��2q�54      ��55      �� *CurrentEmployer.MobileNumber+�� 57      #���   6   $��E-mail Address��6D   �� 58      $��0,0,0,8q�6   $��2q�59      ��5:      �� *CurrentEmployer.EmailAddress+�� 5<      #���   6   $��Website��6D   �� 5=      $��0,0,0,8q�6   $��2q�5>      ��5?      �� *CurrentEmployer.Website+�� 5A      #���   6   $��Notes��6D   �� 5B      $��0,0,0,8q�6   $��2q�5C      ��5D      �� *CurrentEmployer.Notes+5F      5G      �� 5H   
   $��1��6   
�������6   �� 5I   
   $��1��6   $��8q�5J      $
��Left=�5K      
 �� Orientation$
 Vertical=�5L      .+�5N      �� -   5         ��Name$ 
btnAddress��5N      $��75��5O      $��23��5P      $
��Left=�5Q      $	��Top=�5R      $��Address��5S      5U      �� 5V   
   -   5        $ Action��5V      $��1��5W      $��8q�5X      $��Right=�5Y      $
 
Horizontal=�5Z      .+�5[      �� -   5        $ btnSave��5[      $��75��5\      $��23��5]      $��0,0,4,0q�5^      $
��Save��5_      �� 5`      -   5        $ 	btnCancel��5`      $��75��5a      $��23��5b      $��Cancel��5c      5d      5e      5f      