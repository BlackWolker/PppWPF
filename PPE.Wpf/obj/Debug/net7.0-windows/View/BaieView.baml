   M S B A M L   `   `   `  ����B  >PPE.Wpf, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:PPE.Wpf.ViewModelsPPE.Wpf.ViewModels  5          PPE.Wpf.View.BaieView   5      W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      c _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ag cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a:Icon-http://metro.mahapps.com/winfx/xaml/iconpacks   5      Fmc;http://schemas.openxmlformats.org/markup-compatibility/2006   5      <d2http://schemas.microsoft.com/expression/blend/2008   5      3
viewmodels clr-namespace:PPE.Wpf.ViewModels   5      
�������.��5      � $��1��6   $��30 20 20 20q�6     � RowDefinitions  5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� $��Baies��6   $��1��6!   $��32(�6.   $��SemiBold"�6<   $��0 20 0 0q�6R   $
��Left=�6d   ���#1215186   �� 5   
   $��1��6   ���#dae2ea$��
0,51,0,180q�64   $��4��6H   $��2��6U   �� 5   
   $��2��6    �� Orientation$ 
Horizontal=�6"   $��0 10 0 0q�6;   .+�5      �� $�� ��6      	tabButton#��[  6!   ���#784ff26D   5!      �� 5$   
   $��Worktogether��6   $��4��6(   $��18(�65   $��SemiBold"�6C   ���#121518$
��Left=�6n   $��Center=�6�   �� 5&   
   $��Filtre��6   $��4��6"   $��13(�6/   $��SemiBold"�6=   $��	0 0 215 0q�6S   ���#121518$��Right=�6{   $��Center=�6�   � 5)   
   $	��200��6   $��Right=�6   $��4��67   .+�5*      �� $
��15 0q�6   $��Center=�6&   ���#b0b9c6 J� IsHitTestVisible$ False��6V    K� ZIndex$ 1��6o   $��Chercher une donnée...��6�   �� 5+      -   5         ��Name$ 
textFilter��5+       
 Filter#��[ 6*   5,      &   System.Windows.Controls.DataGrid  5/   
      AutoGenerateColumns$ False��61   $��1��6M     DataGridStyle1#���  6^     DataGridCellStyle1   	CellStyle# �  6�     DataGridColumnHeaderStyle1   ColumnHeaderStyle# �  6�     DataGridRowStyle1   RowStyle# �  6�   $��5��6(  ��6   �� *Baies+	   Columns	 50      4  .System.Windows.Controls.DataGridCheckBoxColumn  51      ,  &System.Windows.Controls.DataGridColumn
   CanUserResize$
 False��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$
 auto 6?     CheckBoxStyle11  +System.Windows.Controls.DataGridBoundColumn   ElementStyle# [ 6L      HeaderTemplate 52      �� 53      .R�54      �� #��[ 6'   55      57      0  *System.Windows.Controls.DataGridTextColumn  59         Header$ Identifiant��6%      
IsReadOnly$
 True��6:   $
 False��6L   $
 auto 6b      Binding 6o   �� *Id+  5;      $
 Code��6%   $
 True��63   $ * 6E    6O   �� *Name+  5=      $ Nombre��6%   $
 True��65   $ * 6G    6Q   �� *NbSpot+  5@      $  ��6%   $
 True��60   $ * 6B     5A      $  ��6%   $
 True��60   $ * 6B   5D      5E      5F      