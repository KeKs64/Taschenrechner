   M S B A M L   `   `   `  ����I  ETaschenrechner, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:TaschenrechnerTaschenrechner  5      !    Taschenrechner.SettingsView   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:Taschenrechner     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5         BackgroundBrush#���   5
      .��5      � .+�5   
   �� $��50��5      $��20��5      $��
379,10,0,0q�5      $
��Left=�5      $	��Top=�5      $
��Home��5      ��5      �� *NavigateToTRCommand+5      �� 5   
   $��95��5      $��40��5      $��	10,10,0,0q�5      $
��Left=�5      $	��Top=�5      
������ 
������ $��25(�5        ForegroundBrush#���  5        �� 
IsReadOnly$
  True��5       $��Settings��5!      d� 5"   
   $��60��5#      $��30��5$      $��
58,140,0,0q�5%      $
��Left=�5&      $	��Top=�5'      ��5(      �� *SwitchThemeCommand+ d� 	IsChecked 5)      �� *IsLightTheme+ �� Mode$ OneWay=���5*      �� 5+      .R�5,      ��  ��Name$ 
ToggleRand��5-      $��58��5.      $��30��5/      
������� �� CornerRadius$ 15��51      ._�52      �� $ ToggleKreis��53      $��22��54      $��22��55      $��4,0,4,0q�56      $
��Left=�57      
�������$ 15��59       J� Effect 5:      3  -System.Windows.Media.Effects.DropShadowEffect  5;   "      Opacity$ .2Q�63   5=      5>       �� Triggers 5?      P� 5@       P� Property �@d�	IsChecked	 P� Value$	 FalseY�6D   . �5A      �� 
 �� 
TargetName$
 ToggleKreis��6%    �� Property � �� �� Value$ Right=�6]   �� 5B      $
 ToggleKreis��6%    � �� �#4cd6496T   5C      P� 5E       �@d�	IsChecked$
	 TrueY�6D   . �5F      �� $
 
ToggleRand��6%    � ��
 �����6S   5G      5I      5K      �� 5L   
   $	��212��5M      $��40��5N      $��192,135,0,0q�5O      $
��Left=�5P      $	��Top=�5Q      #���   5R      #���   5S      $��27(�5T      #���  5U      $
  True��5V      $��Light/DarkMode��5W      5Y      5Z      