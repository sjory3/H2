   M S B A M L   `   `   `  ����G  CColor Picker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Color_PickerColor_Picker  5   	       Color_Picker.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Color_Picker     5   	     � Title$  
MainWindow��5   	   $	��450��6   $��552.203��6)   .��5	      � $��0,0,2,0q�6   .+�5
   
   �� -   5         ��Name$ 	RedSlider��5
      $
��Left=�6$   $��155,223,0,0q�6?   $	��Top=�6T   $��26��6l   $	��255��6x   
�������
�������
������� � Maximum$	 255Q�6�    �� IsSnapToTickEnabled . 6�   �� 5   
   -   5        $ GreenSlider��5      $
��Left=�6&   $��155,271,0,0q�6A   $	��Top=�6V   $��26��6n   $	��255��6z   $	 255Q�6�    . 6�   �� 5   
   -   5        $ 
BlueSlider��5      $
��Left=�6%   $��155,318,0,0q�6@   $	��Top=�6U   $��26��6m   $	��255��6y   $	 255Q�6�    . 6�   �� 5   
   -   5         ��Name$ 
ColorPanel��5      $
��Left=�6)   $	��100��6D   $��
155,84,0,0q�6Q   $	��Top=�6e   $	��255��6}   
���   �6�   �� 5   
   -   5         ��Name$ LableRed��5      $	��RED��6"   $
��Left=�60   $��
89,223,0,0q�6K   $	��Top=�6_    J� RenderTransformOrigin$ 0.318,-3.434&�6w   �� 5   
   -   5        $ 
LableGreen��5      $��GREEN��6$   $
��Left=�64   $��
89,271,0,0q�6O   $	��Top=�6c   $ 0.318,-3.434&�6{   �� 5   
   -   5        $ 	LableBlue��5      $
��BLUE��6#   $
��Left=�62   $��
89,318,0,0q�6M   $	��Top=�6a   $ 0.318,-3.434&�6y   �� 5   
   -   5        $ LableRedValue��5      $��0��6'   $
��Left=�63   $��434,223,0,0q�6N   $	��Top=�6c   $ 0.318,-3.434&�6{   $��50��6�   �� 5   
   -	   5        $ LableGreenValue��5      $��0��6)   $
��Left=�65   $��434,271,0,0q�6P   $	��Top=�6e   $ 0.318,-3.434&�6}   $��50��6�   �� 5   
   -
   5        $ LableBlueValue��5      $��0��6(   $
��Left=�64   $��434,318,0,0q�6O   $	��Top=�6d   $ 0.318,-3.434&�6|   $��50��6�   �� 5   
   -   5        $ LableHexValues��5      $�� ��6(   $
��Left=�63   $��262,364,0,0q�6N   $	��Top=�6c   $ 0.318,-3.434&�6{   5      5      