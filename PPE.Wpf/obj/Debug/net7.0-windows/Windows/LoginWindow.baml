   M S B A M L   `   `   `  ����B  >PPE.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:PPE.Wpf.WindowsPPE.Wpf.Windows  5   	   !    PPE.Wpf.Windows.LoginWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:PPE.Wpf.Windows     5   	     � WindowStartupLocation$  CenterScreen=�5       � WindowStyle$
 None=�5	   	    � AllowsTransparency$
 True��6   
������  � Title$ LoginWindow��5
   	   $	��620��6   $	��800��6*   .��5      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $	��500 �6   �� 5      $��* �6   .+�5   
   �� -   5        $��/images/Close.png��5      $��1��6+    K� ZIndex$ 1��6;      
ImageClose#��[  6d   �� 5   
   
�������$��1��6$    �� CornerRadius$ 0 0 0 0��64   $��Right=�6K   $	��500��6g   ._�5      �� $��Center=�6   .+�5      �� $��Connectez-vous��6     	titleText#��[ 62   ���#7b5cd66U   �� 5       �� Orientation$ 
Horizontal=�6   $
��0 20q�66   $��Center=�6D   .+�5      �� $��/Images/logo.png��6   $	��100��66   $	��100��6B   5      �� 5      $��1q�6   ���#acb0af$
��70 7q�6C   $ 5��6Q   ._�5      � $	��7 9q�6    5      �� 5      $
��Auto �6/   �� 5      $��* �6/   .+�5"      .  (MahApps.Metro.IconPacks.PackIconMaterial     Kind$ EmailOutline=�60   �� 5#      -   5        	 ��Name$	 	textEmail��5#   $   $��Email��6W     textHint#��[ 6d   �� 5$      -   5        
 ��Name$
 txtEmail��5$   "     textBox#��[ 6W   5%      5&      �� 5)      $��1q�6   ���#acb0af$
��70 7q�6C   $ 5��6Q   ._�5*      � $	��7 9q�6    5+      �� 5,      $
��Auto �6/   �� 5-      $��* �6/   .+�50        $ LockOutline=�60   �� 51      -   5        $	 textPassword��51   $   $��Mot de passe��6]   #��[ 6q   G� 52      -   5         G�Name$ txtPassword��52   &   #��[ 6e   53      54      �� 56      -   5        $��	Connexion��56        
mainButton#��[ 6G   58      59      5:      5;      