var chart = {
    /*
     ID = Element Id
     Title = Name Of Chart 
     SubTtile = Subitle 
     Option = option.push(option)
     Value = value.push(value);
     */
    BarChart: function (Id,Title,SubTitle , Option,value) {
        //BARCHART
        Highcharts.chart(Id, {

            title: {
                text: Title
            },

            subtitle: {
                text: Common.CheckIsNullAndReplace(SubTitle, Title)
            },

            xAxis: {
                categories: Option
            },

            series: [{
                type: 'column',
                colorByPoint: true,
                data: value,
                showInLegend: true,
                dataLabels: {
                    enabled: true
                }
            }]

        });
    },


    /*
     ID = Element Id
     Title = Name Of Chart 
     DataArray = value.push(value,option);
     */
    PieChart: function (Id, Title, DataArray) {
      
        Highcharts.chart(Id, {
            /**/
            chart: {
                plotBackgroundColor: null,
                plotBorderWidth: null,
                plotShadow: true,
                type: 'pie'
            },
            title: {
                text: Title
            },
            tooltip: {
                pointFormat: '{series.name}: <b>{point.percentage:.1f}%</b>'
            },
            plotOptions: {
                pie: {
                    allowPointSelect: true,
                    cursor: 'pointer',
                    dataLabels: {
                        enabled: true,
                        format: '<b>{point.name}</b>: {point.percentage:.1f} %',
                        style: {
                            color: (Highcharts.theme && Highcharts.theme.contrastTextColor) || 'black'
                        },
                        connectorColor: 'silver'
                    }
                }
            },
            series: [{
                name: 'Chart',
                data: DataArray
            }]
        });
    }
}