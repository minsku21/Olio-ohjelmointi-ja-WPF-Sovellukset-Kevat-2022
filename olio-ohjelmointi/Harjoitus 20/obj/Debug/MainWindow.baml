   M S B A M L   `   `   `  ����G  CHarjoitus 20, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:Harjoitus_20Harjoitus_20  5   	       Harjoitus_20.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:Harjoitus_20     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � ��5
   
   �� 5       �� EndPoint$ 0.5,1&�6"    � MappingMode$ RelativeToBoundingBox=�63    �� 
StartPoint$ 0.5,0&�6W    �� RelativeTransform 5      V� 5      .~�5      ��  �� CenterY$	 0.5Q�6)    �� CenterX$	 0.5Q�67   �� 5       �� CenterY$	 0.5Q�6(    �� CenterX$	 0.5Q�66   �� 5      	 �� Angle$		 -90Q�6*   
 �� CenterY$	
 0.5Q�66    �� CenterX$	 0.5Q�6D   T� 5      5      .��5      �  � Color$ Black��6    � Offset$ 1Q�6-   � 5      $ White��6   $ 0.113Q�6-   � 5      $ 	#FFB7B7B7��6   $ 0.541Q�61   � 5      $ White��6   $ 0.416Q�6-   5      .+�5   
   �� $
��Left=�6   $��
477,32,0,0q�6/   $
��Wrap=�6C   $��Etunimi��6W   $	��Top=�6f   �� 5   
   -   5         ��Name$ 
tb_Etunimi��5      $
��Left=�6&   $��23��6A   $��
477,53,0,0q�6M    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��120��6�   �� 5   
   $
��Left=�6   $��
649,32,0,0q�6/   $
��Wrap=�6C   $��Sukunimi��6W   $	��Top=�6g   �� 5   
   -   5        $ tb_Sukunimi��5      $
��Left=�6'   $��23��6B   $��
649,53,0,0q�6N   $
 Wrap=�6b   $	��Top=�6v   $	��120��6�   �� 5   
   $
��Left=�6   $��
477,91,0,0q�6/   $
��Wrap=�6C   $��Puhelinumero��6W   $	��Top=�6k   �� 5   
   -   5        $ tb_Puhelinnumero��5      $
��Left=�6,   $��23��6G   $��477,112,0,0q�6S   $
 Wrap=�6h   $	��Top=�6|   $	��120��6�   �� 5    
   $
��Left=�6   $��
649,91,0,0q�6/   $
��Wrap=�6C   $��Sähköposti��6W   $	��Top=�6i   �� 5!   
   -   5        $ tb_Sähköposti��5!      $
��Left=�6)   $��23��6D   $��649,112,0,0q�6P   $
 Wrap=�6e   $	��Top=�6y   $	��120��6�   �� 5"   
   $
��Left=�6   $��477,149,0,0q�6/   $
��Wrap=�6D   $��OpiskelijaID��6X   $	��Top=�6l   �� 5#   
   -   5        $ tb_OpiskelijaID��5#      $
��Left=�6+   $��23��6F   $��477,170,0,0q�6R   $
 Wrap=�6g   $	��Top=�6{   $	��120��6�   �� 5$   
   -   5         ��Name$ btn_LisääOpiskelija��5$      $��Lisää Opiskelija��6.   $
��Left=�6I   $��476,219,0,0q�6d   $	��Top=�6y   $��85��6�   $��27��6�   ���	#FF74FF006�   �� 5%   
   -   5        $ btn_PoistaOpiskelija��5%      $��Poista Opiskelija��6/   $
��Left=�6K   $��649,219,0,0q�6f   $	��Top=�6{   $��95��6�   $��27��6�   ���	#FFFF12006�   �� 5&   
   -   5        $ btn_TallennaOpiskelijat��5&      $��Tallenna Opiskelijat��62   $
��Left=�6Q   $��476,349,0,0q�6l   $	��Top=�6�   $	��107��6�   $��30��6�   �� 5'   
   -	   5        $ btn_HaeOpiskelijat��5'      $��Hae Opiskelijat��6-   $
��Left=�6G   $��649,349,0,0q�6b   $	��Top=�6w   $��95��6�   $��30��6�   &   System.Windows.Controls.DataGrid  5(   
   -
   5          Name$ dg_Opiskelijat��5(      $	��428��6+   $
��Left=�6O   $	��Top=�6j      AutoGenerateColumns .     CanUserReorderColumns .     CanUserDeleteRows .  $��	10,10,0,0q�6�   ��67   ��    Columns 5)      0  *System.Windows.Controls.DataGridTextColumn  5*      ,  &System.Windows.Controls.DataGridColumn   Header$ Etunimi��6%      
IsReadOnly . 1  +System.Windows.Controls.DataGridBoundColumn   Binding 66   �� *	Etunimi+6R     5+      $ Sukunimi��6%    .  67   �� *
Sukunimi+6T     5,      $ Puhelinnumero��6%    .  6<   �� *Puhelinnumero+6^     5-      $ Sähköposti��6%    .  69   �� *Sähköposti+6X     5.      $ Opiskelija ID��6%    .  6<   �� *OpiskelijaID+6]   4  .System.Windows.Controls.DataGridCheckBoxColumn  5/      $ Poista��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$	 50* 6X    69   �� *
IsSelected+6X   51      52      53      