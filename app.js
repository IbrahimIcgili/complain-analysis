const Fs = require('fs');
const CsvReadableStream = require('csv-reader');
const { Pool, Client } = require('pg');

// User ID=postgres;Password=123456;Host=localhost;Port=5432;Database=yazlab_akrep;Search Path=public;
const client = new Client({
    user: 'postgres',
    host: 'localhost',
    database: 'yazlab_project2',
    password: '123456',
    port: 5432,
  })
  client.connect()
 


var x = 0;
var failCount = 0;
var oku = (ibo) => {
    x = x +1;

    var row = ibo[x];

    client.query(`
        INSERT INTO 
            public.complaints("Datereceived", "Product", "Sub-product", "Issue", "Sub-issue", "Consumer complaint narrative", "Company public response", "Company", "State", "ZIP code", "Tags", "Consumer consent provided?", "Submitted via", "Date sent to company", "Company response to consumer", "Timely response?", "Consumer disputed?", "Complaint ID")
        VALUES ('${row[0]}', '${row[1]}', '${row[2]}', '${row[3]}', '${row[4]}', '${row[5]}', '${row[6]}', '${row[7]}', '${row[8]}', '${row[9]}', '${row[10]}', '${row[11]}', '${row[12]}', '${row[13]}', '${row[14]}', '${row[15]}', '${row[16]}', ${row[17] || 0})
    `).then(() => {
            console.log("Insert ->" + x);
            oku(ibo);
    }).catch(err => {
        failCount = failCount + 1;
        console.log("Fail 😉 ->"+ failCount + "-" + x);
        oku(ibo);
    });

};

var iborahim = [];

let inputStream = Fs.createReadStream('rows.csv', 'utf8');
inputStream
	.pipe(new CsvReadableStream({ parseNumbers: true, parseBooleans: true, trim: true }))
	.on('data', function (row) {
	    iborahim.push(row);
	})
	.on('end', function () {
        console.log("==============================")
	    oku(iborahim);
	});