   M S B A M L   `   `   `  ����G  CPrakticka2.0, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:Prakticka2._0Prakticka2._0  5   	   "    Prakticka2._0.ProverkaMashin   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:Prakticka2._0     5   	   -   5          � Title$  ProverkaMashin��5   	   $	��450��6    $��297.674��6-    � WindowStyle$
 None=�6=    � AllowsTransparency .  � 	Resources 5	      !   Prakticka2._0.loginDataSet2   loginDataSet2  mashinaViewSource �� Source �� Source��%X   &	        &	      7     5
   
   6   �� 5   
    69   �� *	Mashina+8   5      .��5      �  � DataContext# [ 6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ mashinaDataGrid��5         AutoGenerateColumns .  	   EnableRowVirtualization	 . 
   RowDetailsVisibilityMode$
 VisibleWhenSelected=�6   $��0,10,0,0q�6�   ��6g   ��    Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        машинаColumn��,  &System.Windows.Controls.DataGridColumn   Header$ Машина��5   V      Width5  /System.Windows.Controls.DataGridLengthConverter$	 100 6f   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6;   �� *Машина+6f     5      -   5        #где_находитсяColumn��$ Где находится��5   d   $	 100 6{    6B   �� *Где_находится+6{   5      �� 5   
   -   5        $	��←��5      $
��Left=�6   $��
200,10,0,0q�68   $	��Top=�6L   $��98��6d   $��25��6o   $��18(�6{   
������� J� RenderTransformOrigin$ 
0.523,0.54&�6�   �� 5   
   -   5        
���   �$��1q�5   %   $
��Left=�69   $��10��6T   $	��Top=�6`   $	��298��6x   ���	#FF31D4746�   5      5      