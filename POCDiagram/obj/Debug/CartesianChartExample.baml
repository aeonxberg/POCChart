   M S B A M L   `   `   `  ����V  RLiveCharts.Wpf, Version=0.7.16.0, Culture=neutral, PublicKeyToken=3b585c2a5f1a92c1G4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf  5       
POCDiagram&    POCDiagram.CartesianChartExample   5      Bmc;http://schemas.openxmlformats.org/markup-compatibility/2006  5      8d2http://schemas.microsoft.com/expression/blend/2008  5      <lvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf  5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5        � DataContext  5	      ��  �� RelativeSource �� *Self+.��5      �  � RowDefinitions 5   
   �� 5      $
��Auto �6   6,   �� 5      $��* �6   6)   .+�5   
   ��  �� Orientation$ 
Horizontal=�6   .+�5      �� -   5         ��Name$ AvailabilityLabel��5      $��Beschikbaarheid��6/    J� RenderTransformOrigin$ 3.389,0.479&�6I   $��
0,0,0,-0.2q�6m   $��12(�6�   �� 5      $��Center=�6:    d� 	IsChecked 6   �� *Availability+6:   �� 5      -   5        $ PlannedLabel��5      $��	Ingepland��6*   $ 3.389,0.479&�6>   $��
0,0,0,-0.2q�6b   $��12(�6v   �� 5      $��Center=�65    6   �� *	Planned+65   �� 5      -   5        $ 
WhiteSpace��5      $�� ��6)   $	��150��65   �� 5      -   5        $ 	UnitLabel��5      $��Uren per week��6'   $ 3.389,0.479&�6?   $��
0,0,0,-0.2q�6c   $��12(�6w   $
��Bold"�6�   $��Right=�6�   5      #   LiveCharts.Wpf.CartesianChart  5   
   $��1��6   $	��700��6*   &    LiveCharts.Wpf.Charts.Base.Chart   	Hoverable .     Series 6H   �� *CartesianSeriesCollection+	   AxisX	 5         LiveCharts.Wpf.Axis  
   Labels
 6   �� *
NameList+   	Separator 5         LiveCharts.Wpf.Separator  5         Step$ 1X�6(   63   5      5       5!      5"      