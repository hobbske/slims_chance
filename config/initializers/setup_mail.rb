ActionMailer::Base.delivery_method = :smtp
ActionMailer::Base.smtp_settings = {
	:address							=> 'smtp.sendgrid.net',
	:port									=> '587',
	:authentication				=> :plain,
	:user_name						=> 'app47281624@heroku.com',
	:password							=> 'w9agvw981161',
	:domain								=> 'heroku.com',
	:enable_starttls_auto	=> true
}