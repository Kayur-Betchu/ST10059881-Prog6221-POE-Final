   M S B A M L   `   `   `  ����U  QST10059881_PROG6221_POE_P3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:ST10059881_PROG6221_POE_P3ST10059881_PROG6221_POE_P3  5   	   -    'ST10059881_PROG6221_POE_P3.SelectRecipe   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:ST10059881_PROG6221_POE_P3     5   	     � Title$  SelectRecipe��5   	   $	��450��6   $	��800��6+   ��5	      �� 5
   
    �� ImageSource$ Resources/samosa.jpg��6   .��5      �  � ColumnDefinitions 5   
   �� 5      $��20 �6   �� 5      $��* �6   �� 5      $��20 �6    � RowDefinitions 5   
   �� 5      $��20 �6   �� 5      $��70 �6   �� 5      $	��150 �6   �� 5      $	��150 �6   �� 5      $��50 �6   �� 5      $��20 �6   .+�5   
   �� -   5         ��Name$ lblSelectRecipe��5      $��1��6)   $��Select Recipe: ��69   $
��Left=�6S   $��41,0,0,0q�6n   $��1��6�   $��Center=�6�   $��25(�6�   
����d�$��7q�6�   
����·�6�   &   System.Windows.Controls.DataGrid  5   
   -   5          Name$ grdIngredients��5         AutoGenerateColumns . $��1��6k   $��2��6{   ��6G   �� *ingredients+6{     5   
   -   5        $ grdSteps��5       .  $��1��6_   $��3��6o   ��6A   �� *steps+   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ StepDescription��6:   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 6%   �� 6:   5       �� 5!   
   -   5        
 ��Name$
 	cmbRecipe��5!      $��1��6&   $��Center=�66   $��0,19,0,0q�6S   $��1��6e   $	��Top=�6r   $	��120��6�   �� 5"   
   -   5         ��Name$ btnMainMenu��5"      $��1��6&   $��	Main Menu��66   $��Center=�6J   $��0,0,0,15q�6g   $��4��6y   
���  ��$��4q�6�   $��90��6�   $��35��6�   �� 5#   
   -   5        $ 
btnDisplay��5#      $��1��6%   $��Display��65   $
��Left=�6G   $��
537,20,0,0q�6b   $��1��6v   $	��Top=�6�   
��� ���$��80��6�   6�   5$      5%      