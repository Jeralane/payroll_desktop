   M S B A M L   `   `   `  ����  PayrollSystem-    'PayrollSystem.Views.Utilities.LoginView   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  Login: Payroll System��5   	   $	��500��5   	   $	��386��5   	    � AllowsTransparency . $��Ubuntu)�5	   	    � Icon$8 2/Images\pelfusion_long_shadow_media_calculator.ico��5
   	    � 
ResizeMode$ NoResize=�5   	    � Topmost .  � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	   ��5   	   Z� .��5      � -   5         �Name$ 
LayoutRoot��5      .+�5   
   �� $��10q�6      LoginViewColor#���   5       J� Opacity$	 0.8Q�5      	 J� Effect	 5      3  -System.Windows.Media.Effects.DropShadowEffect  5      
   
BlurRadius$
 10Q�6#      	Direction$ 0Q�5   #      Opacity$	 0.8Q�5   #      ShadowDepth$ 0Q�5   #   5      � 5   
   $��20q�6   .+�5      �� #���   6   �� 5      -   5         ��Name$ imgUserAuthenticationLogo��5      $	��200��5      $	��200��5      $��
-40,90,0,0q�5      $
��Left=�5       $	��Top=�5!      $	 0.6Q�5"      $6��0/PayrollSystem;component/Images/key_10_light.png��5#      $
��Fill=�5$      �� 5%      $��
0,100,40,0q�6   $��Right=�5&      $	��Top=�5'       �� Orientation$ 
Horizontal=�5(      .+�5)      �� $��297.355��6   $	��Top=�5*      $
 0.85Q�5,      $ Vertical=�5-       +� FocusedElement 5+      ��  �� ElementName$ txtUserName��.+�5.      �� $��0,0,0,4q�6    $��16(�5/       $��Normal"�50         ModuleTitleLight#���  51       $��	User Name��52       $
��Wrap=�53       �� 54      -   5         ��Name$ txtUserName��54      $��32��55      $��0,0,0,8q�56      $��16(�57      $
��Bold"�58      $��4,3,1,1q�59       �� TextWrapping$
 Wrap=�5:      �� 5;      $��0,0,0,4q�6    $��16(�5<       $��Normal"�5=       #���  5>       $��Password��5?       $
��Wrap=�5@       G� 5A      -   5         G�Name$ txtPassword��5A   "   $��32��5B   "   $��0,0,0,12q�5C   "   $��16(�5D   "   $��3,3,1,1q�5E   "   � 5F      $��36��6   $��0,10,0,0q�6'    � ColumnDefinitions 5G      �� 5H      �� 5I      $��6 �6/   �� 5J      .+�5L      �� -   5         ��Name$ btnOk��5L   !   $��32��5M   !   $��Login��5N   !   $��14.667(�5O   !    �� 	IsDefault . 5P   !   �� 5Q      -   5        $ 	btnCancel��5Q   !   $��2��5R   !   $��32��5S   !   $��Cancel��5T   !   $��14.667(�5U   !    �� IsCancel . 5V   !   5W      5X      5Y      � 5Z      $��1q�6   $	��Top=�5[      ���	#0F000000.+�5]      �� -   5        $ imgPayrollLog��5]      $��60��5^      $��60��5_      $��0,6,6,0q�5`      $��Right=�5a      $	��Top=�5b      $	 0.4Q�5c      $P��J/PayrollSystem;component/Images/pelfusion_long_shadow_media_calculator.ico��5d      $
��Fill=�5e      �� 5f      $��20,12,20,14q�6   $
��Left=�62   .+�5g      �� $��24(�6    $��Normal"�5h       #���  5i       $��User Authentication��5j       $
��Wrap=�5k       �� 5l      -   5         ��Name$ 
lblVersion��5l       $��0,-6,0,0q�5m       $��Bottom=�5n       $��16(�5o       $��Normal"�5p       ���	#66FFFFFF#���  5r       $ ��Payroll System Version 2.0��5s       $
��Wrap=�5t       5u      5v      � 5w      $��1q�6   $��Bottom=�5x      ���	#0F000000.+�5z      �� $��10q�6   .+�5{      �� -	   5        $ lblVersion1��5{       $��Right=�5|       $��Bottom=�5}       $��Segoe UI Semibold)�5~       $��10.667(�5       $��Normal"�5�       #���  5�       $3��-Orion Task Force Payroll System © 2014 | JEA��5�       $
��Wrap=�5�       5�      5�      5�      5�      5�      