   M S B A M L   `   `   `  ����H  DPayrollSystem, Version=2.0.0.0, Culture=neutral, PublicKeyToken=nullM+clr-namespace:PayrollSystem.Views.EmployersPayrollSystem.Views.Employers  5   	   1    +PayrollSystem.Views.Employers.EmployersList   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   =local+clr-namespace:PayrollSystem.Views.Employers     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$  Employers List��5   	   $��Segoe UI)�5   	    � Icon$6 0/PayrollSystem;component/Images/organization.png��5	   	    � 
ResizeMode$ NoResize=�5
   	    � SizeToContent$ WidthAndHeight=�5   	    � WindowStartupLocation$ CenterScreen=�5   	    � 	Resources 5         ButtonElementStyle �� 
TargetType �� Property �� Value��%�   &	        �� 5   
   " ��6+   .�5      ��  �@��Orientation$ 
Horizontal=�6,   �� 5       � ��$ 4q�6'   5      5      	 � DataContext	 5      6   0PayrollSystem.Views.Employers.EmployersViewModel  5   
   .��5      � $	��760��6   $	��570��6   
 � RowDefinitions
 5   
   �� 5      $
��Auto �6   �� 5      $
��Auto �6   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   � 
�������.+�5      �� $��8q�6    �� Orientation$ 
Horizontal=�6$   .+�5       �� $��4,4,4,4q�6   #���   6.   .+�5!      �� $��26��6!   $��26��6,   .+�5"      �� $6��0/PayrollSystem;component/Images/organization.png��6    5#      �� 5$      $��4,0,0,0q�6!   $ Vertical=�62   .+�5%      ��   ModuleTitle#���  6$   $��Employers List��6J   �� 5&        ModuleDescription#���  6$   $����Here is a list of all Employers. To filter the grid type into the Filter by keyword textbox the Employer Name then click Refresh.��6P   5'      5(      5)      5*      � 5+   
   $��1��6   $��26��5,      $��8,12,8,0q�5-      $��Bottom=�5.       � ColumnDefinitions 5/      �� 50      $
��Auto �6#   �� 51      $��* �6#   �� 52      $��80 �6#   .+�54      �� $��Center=�6   $��Filter by keyword��63   �� 55      -   5        $��txtFilterByKeyword��55      $��1��56      $	��6,0q�57      $��Center=�58      $��2q�59      �� 5:      -   5        $��
btnRefresh��5:      $��2��5;      $��Refresh��5<      5=      &   System.Windows.Controls.DataGrid  5>   
   -   5          Name$ 	dataGrid1��5>      $��2��5?      $��8q�5@         AutoGenerateColumns .     HeadersVisibility$ Column=�5B         HorizontalGridLinesBrush
 �����   
IsReadOnly .    SelectionMode$ Single=�5G         VerticalGridLinesBrush
 �������5E      �� *
Collection+ �� SelectedItem 5F      �� *SelectedItem+��5I      �� 5J        BorderMediumColor �� Color# �  6"      Columns 5L      0  *System.Windows.Controls.DataGridTextColumn  5M      ,  &System.Windows.Controls.DataGridColumn   Header$ #��6D   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *
row_number+6D     5N      -   5        dataGridTextColumn��   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 5O   %   $ Employer Name��5Q   %    5P   %   �� *Name+5Q   %     5R      $ * 6%   $ Branch��5T   %    5S   %   �� *Branch+5T   %   5V      � 5W   
   $��3��6   $��26��5X      $��8,0,8,8q�5Y      $��Bottom=�5Z      .+�5[      �� -   5         ��Name$ btnAdd��5[      $��80��5\      $
��Left=�5]      $	��Add��5^      �� 5_      -   5        $ btnEdit��5_      $��80��5`      $��84,0,0,0q�5a      $
��Left=�5b      $
��Edit��5c      �� 5d      -   5        $ 	btnDelete��5d      $��80��5e      $��	168,0,0,0q�5f      $
��Left=�5g      $��Delete��5h      5i      5j      5k      